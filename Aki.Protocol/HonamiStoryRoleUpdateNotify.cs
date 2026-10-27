using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079C RID: 1948
	[NetMessage(EMessageId.HonamiStoryRoleUpdateNotify)]
	public sealed class HonamiStoryRoleUpdateNotify : IMessage<HonamiStoryRoleUpdateNotify>, IMessage, IEquatable<HonamiStoryRoleUpdateNotify>, IDeepCloneable<HonamiStoryRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AFAB RID: 44971 RVA: 0x001A5889 File Offset: 0x001A3A89
		[NullableContext(1)]
		public static HonamiStoryRoleUpdateNotify Create()
		{
			return new HonamiStoryRoleUpdateNotify();
		}

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x0600AFAC RID: 44972 RVA: 0x001A5890 File Offset: 0x001A3A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x0600AFAD RID: 44973 RVA: 0x001A5893 File Offset: 0x001A3A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AFAE RID: 44974 RVA: 0x001A589A File Offset: 0x001A3A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRoleUpdateNotify()
		{
		}

		// Token: 0x0600AFAF RID: 44975 RVA: 0x001A58AD File Offset: 0x001A3AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRoleUpdateNotify(HonamiStoryRoleUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleId_ = other.roleId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFB0 RID: 44976 RVA: 0x001A58E3 File Offset: 0x001A3AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRoleUpdateNotify Clone()
		{
			return new HonamiStoryRoleUpdateNotify(this);
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x0600AFB1 RID: 44977 RVA: 0x001A58EB File Offset: 0x001A3AEB
		// (set) Token: 0x0600AFB2 RID: 44978 RVA: 0x001A58F3 File Offset: 0x001A3AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x0600AFB3 RID: 44979 RVA: 0x001A58FC File Offset: 0x001A3AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x0600AFB4 RID: 44980 RVA: 0x001A5904 File Offset: 0x001A3B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryRoleUpdateNotify);
		}

		// Token: 0x0600AFB5 RID: 44981 RVA: 0x001A5914 File Offset: 0x001A3B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.roleId_.Equals(other.roleId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x001A5964 File Offset: 0x001A3B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.roleId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AFB7 RID: 44983 RVA: 0x001A59B1 File Offset: 0x001A3BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AFB8 RID: 44984 RVA: 0x001A59BE File Offset: 0x001A3BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFB9 RID: 44985 RVA: 0x001A59C8 File Offset: 0x001A3BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleId_.WriteTo(ref output, HonamiStoryRoleUpdateNotify._repeated_roleId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFBA RID: 44986 RVA: 0x001A5A18 File Offset: 0x001A3C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.roleId_.CalculateSize(HonamiStoryRoleUpdateNotify._repeated_roleId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AFBB RID: 44987 RVA: 0x001A5A6C File Offset: 0x001A3C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryRoleUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.roleId_.Add(other.roleId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AFBC RID: 44988 RVA: 0x001A5AB9 File Offset: 0x001A3CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFBD RID: 44989 RVA: 0x001A5AC4 File Offset: 0x001A3CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 40U && num != 42U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.roleId_.AddEntriesFrom(ref input, HonamiStoryRoleUpdateNotify._repeated_roleId_codec);
				}
			}
		}

		// Token: 0x04004F08 RID: 20232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F09 RID: 20233
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04004F0A RID: 20234
		private int activityId_;

		// Token: 0x04004F0B RID: 20235
		public const int RoleIdFieldNumber = 5;

		// Token: 0x04004F0C RID: 20236
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04004F0D RID: 20237
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();
	}
}
