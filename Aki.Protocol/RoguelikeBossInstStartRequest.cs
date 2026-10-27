using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F90 RID: 3984
	[NetMessage(EMessageId.RoguelikeBossInstStartRequest)]
	public sealed class RoguelikeBossInstStartRequest : IMessage<RoguelikeBossInstStartRequest>, IMessage, IEquatable<RoguelikeBossInstStartRequest>, IDeepCloneable<RoguelikeBossInstStartRequest>, IBufferMessage
	{
		// Token: 0x060154E8 RID: 87272 RVA: 0x003176D9 File Offset: 0x003158D9
		[NullableContext(1)]
		public static RoguelikeBossInstStartRequest Create()
		{
			return new RoguelikeBossInstStartRequest();
		}

		// Token: 0x170046FC RID: 18172
		// (get) Token: 0x060154E9 RID: 87273 RVA: 0x003176E0 File Offset: 0x003158E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046FD RID: 18173
		// (get) Token: 0x060154EA RID: 87274 RVA: 0x003176E3 File Offset: 0x003158E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeBossInstStartRequest.Descriptor;
			}
		}

		// Token: 0x060154EB RID: 87275 RVA: 0x003176EA File Offset: 0x003158EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartRequest()
		{
		}

		// Token: 0x060154EC RID: 87276 RVA: 0x003176FD File Offset: 0x003158FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartRequest(RoguelikeBossInstStartRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060154ED RID: 87277 RVA: 0x00317733 File Offset: 0x00315933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartRequest Clone()
		{
			return new RoguelikeBossInstStartRequest(this);
		}

		// Token: 0x170046FE RID: 18174
		// (get) Token: 0x060154EE RID: 87278 RVA: 0x0031773B File Offset: 0x0031593B
		// (set) Token: 0x060154EF RID: 87279 RVA: 0x00317743 File Offset: 0x00315943
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

		// Token: 0x170046FF RID: 18175
		// (get) Token: 0x060154F0 RID: 87280 RVA: 0x0031774C File Offset: 0x0031594C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x060154F1 RID: 87281 RVA: 0x00317754 File Offset: 0x00315954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeBossInstStartRequest);
		}

		// Token: 0x060154F2 RID: 87282 RVA: 0x00317764 File Offset: 0x00315964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeBossInstStartRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060154F3 RID: 87283 RVA: 0x003177B4 File Offset: 0x003159B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.roleList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060154F4 RID: 87284 RVA: 0x00317801 File Offset: 0x00315A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060154F5 RID: 87285 RVA: 0x0031780E File Offset: 0x00315A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060154F6 RID: 87286 RVA: 0x00317818 File Offset: 0x00315A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			this.roleList_.WriteTo(ref output, RoguelikeBossInstStartRequest._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060154F7 RID: 87287 RVA: 0x00317868 File Offset: 0x00315A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.roleList_.CalculateSize(RoguelikeBossInstStartRequest._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060154F8 RID: 87288 RVA: 0x003178BC File Offset: 0x00315ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeBossInstStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.roleList_.Add(other.roleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060154F9 RID: 87289 RVA: 0x00317909 File Offset: 0x00315B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060154FA RID: 87290 RVA: 0x00317914 File Offset: 0x00315B14
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
				if (num != 40U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleList_.AddEntriesFrom(ref input, RoguelikeBossInstStartRequest._repeated_roleList_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008031 RID: 32817
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008032 RID: 32818
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04008033 RID: 32819
		private int activityId_;

		// Token: 0x04008034 RID: 32820
		public const int RoleListFieldNumber = 9;

		// Token: 0x04008035 RID: 32821
		private static readonly FieldCodec<int> _repeated_roleList_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04008036 RID: 32822
		private readonly RepeatedField<int> roleList_ = new RepeatedField<int>();
	}
}
