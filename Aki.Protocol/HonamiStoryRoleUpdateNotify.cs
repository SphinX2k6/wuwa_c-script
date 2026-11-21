using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000788 RID: 1928
	[NetMessage(EMessageId.HonamiStoryRoleUpdateNotify)]
	public sealed class HonamiStoryRoleUpdateNotify : IMessage<HonamiStoryRoleUpdateNotify>, IMessage, IEquatable<HonamiStoryRoleUpdateNotify>, IDeepCloneable<HonamiStoryRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AE55 RID: 44629 RVA: 0x001A2E61 File Offset: 0x001A1061
		[NullableContext(1)]
		public static HonamiStoryRoleUpdateNotify Create()
		{
			return new HonamiStoryRoleUpdateNotify();
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x0600AE56 RID: 44630 RVA: 0x001A2E68 File Offset: 0x001A1068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x0600AE57 RID: 44631 RVA: 0x001A2E6B File Offset: 0x001A106B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AE58 RID: 44632 RVA: 0x001A2E72 File Offset: 0x001A1072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRoleUpdateNotify()
		{
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x001A2E85 File Offset: 0x001A1085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRoleUpdateNotify(HonamiStoryRoleUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleId_ = other.roleId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE5A RID: 44634 RVA: 0x001A2EBB File Offset: 0x001A10BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRoleUpdateNotify Clone()
		{
			return new HonamiStoryRoleUpdateNotify(this);
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x0600AE5B RID: 44635 RVA: 0x001A2EC3 File Offset: 0x001A10C3
		// (set) Token: 0x0600AE5C RID: 44636 RVA: 0x001A2ECB File Offset: 0x001A10CB
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

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x0600AE5D RID: 44637 RVA: 0x001A2ED4 File Offset: 0x001A10D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x0600AE5E RID: 44638 RVA: 0x001A2EDC File Offset: 0x001A10DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryRoleUpdateNotify);
		}

		// Token: 0x0600AE5F RID: 44639 RVA: 0x001A2EEC File Offset: 0x001A10EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.roleId_.Equals(other.roleId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE60 RID: 44640 RVA: 0x001A2F3C File Offset: 0x001A113C
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

		// Token: 0x0600AE61 RID: 44641 RVA: 0x001A2F89 File Offset: 0x001A1189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE62 RID: 44642 RVA: 0x001A2F96 File Offset: 0x001A1196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE63 RID: 44643 RVA: 0x001A2FA0 File Offset: 0x001A11A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleId_.WriteTo(ref output, HonamiStoryRoleUpdateNotify._repeated_roleId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE64 RID: 44644 RVA: 0x001A2FF0 File Offset: 0x001A11F0
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

		// Token: 0x0600AE65 RID: 44645 RVA: 0x001A3044 File Offset: 0x001A1244
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

		// Token: 0x0600AE66 RID: 44646 RVA: 0x001A3091 File Offset: 0x001A1291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE67 RID: 44647 RVA: 0x001A309C File Offset: 0x001A129C
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
				if (num != 72U && num != 74U)
				{
					if (num != 120U)
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

		// Token: 0x04004F01 RID: 20225
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F02 RID: 20226
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04004F03 RID: 20227
		private int activityId_;

		// Token: 0x04004F04 RID: 20228
		public const int RoleIdFieldNumber = 9;

		// Token: 0x04004F05 RID: 20229
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04004F06 RID: 20230
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();
	}
}
