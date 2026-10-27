using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C9 RID: 4553
	[NetMessage(EMessageId.SetBaoziStateRequest)]
	public sealed class SetBaoziStateRequest : IMessage<SetBaoziStateRequest>, IMessage, IEquatable<SetBaoziStateRequest>, IDeepCloneable<SetBaoziStateRequest>, IBufferMessage
	{
		// Token: 0x0601849A RID: 99482 RVA: 0x00388DC1 File Offset: 0x00386FC1
		[NullableContext(1)]
		public static SetBaoziStateRequest Create()
		{
			return new SetBaoziStateRequest();
		}

		// Token: 0x170051CE RID: 20942
		// (get) Token: 0x0601849B RID: 99483 RVA: 0x00388DC8 File Offset: 0x00386FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051CF RID: 20943
		// (get) Token: 0x0601849C RID: 99484 RVA: 0x00388DCB File Offset: 0x00386FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBaoziStateRequest.Descriptor;
			}
		}

		// Token: 0x0601849D RID: 99485 RVA: 0x00388DD2 File Offset: 0x00386FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateRequest()
		{
		}

		// Token: 0x0601849E RID: 99486 RVA: 0x00388DDA File Offset: 0x00386FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateRequest(SetBaoziStateRequest other) : this()
		{
			this.fanEntityId_ = other.fanEntityId_;
			this.baoziEntityId_ = other.baoziEntityId_;
			this.isActive_ = other.isActive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601849F RID: 99487 RVA: 0x00388E17 File Offset: 0x00387017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateRequest Clone()
		{
			return new SetBaoziStateRequest(this);
		}

		// Token: 0x170051D0 RID: 20944
		// (get) Token: 0x060184A0 RID: 99488 RVA: 0x00388E1F File Offset: 0x0038701F
		// (set) Token: 0x060184A1 RID: 99489 RVA: 0x00388E27 File Offset: 0x00387027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FanEntityId
		{
			get
			{
				return this.fanEntityId_;
			}
			set
			{
				this.fanEntityId_ = value;
			}
		}

		// Token: 0x170051D1 RID: 20945
		// (get) Token: 0x060184A2 RID: 99490 RVA: 0x00388E30 File Offset: 0x00387030
		// (set) Token: 0x060184A3 RID: 99491 RVA: 0x00388E38 File Offset: 0x00387038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BaoziEntityId
		{
			get
			{
				return this.baoziEntityId_;
			}
			set
			{
				this.baoziEntityId_ = value;
			}
		}

		// Token: 0x170051D2 RID: 20946
		// (get) Token: 0x060184A4 RID: 99492 RVA: 0x00388E41 File Offset: 0x00387041
		// (set) Token: 0x060184A5 RID: 99493 RVA: 0x00388E49 File Offset: 0x00387049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IsActive
		{
			get
			{
				return this.isActive_;
			}
			set
			{
				this.isActive_ = value;
			}
		}

		// Token: 0x060184A6 RID: 99494 RVA: 0x00388E52 File Offset: 0x00387052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBaoziStateRequest);
		}

		// Token: 0x060184A7 RID: 99495 RVA: 0x00388E60 File Offset: 0x00387060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetBaoziStateRequest other)
		{
			return other != null && (other == this || (this.FanEntityId == other.FanEntityId && this.BaoziEntityId == other.BaoziEntityId && this.IsActive == other.IsActive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060184A8 RID: 99496 RVA: 0x00388EBC File Offset: 0x003870BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FanEntityId != 0L)
			{
				num ^= this.FanEntityId.GetHashCode();
			}
			if (this.BaoziEntityId != 0L)
			{
				num ^= this.BaoziEntityId.GetHashCode();
			}
			if (this.IsActive != 0)
			{
				num ^= this.IsActive.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060184A9 RID: 99497 RVA: 0x00388F2D File Offset: 0x0038712D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060184AA RID: 99498 RVA: 0x00388F3A File Offset: 0x0038713A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060184AB RID: 99499 RVA: 0x00388F44 File Offset: 0x00387144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsActive != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IsActive);
			}
			if (this.BaoziEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BaoziEntityId);
			}
			if (this.FanEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.FanEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060184AC RID: 99500 RVA: 0x00388FB8 File Offset: 0x003871B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FanEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FanEntityId);
			}
			if (this.BaoziEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BaoziEntityId);
			}
			if (this.IsActive != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IsActive);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060184AD RID: 99501 RVA: 0x00389028 File Offset: 0x00387228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetBaoziStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FanEntityId != 0L)
			{
				this.FanEntityId = other.FanEntityId;
			}
			if (other.BaoziEntityId != 0L)
			{
				this.BaoziEntityId = other.BaoziEntityId;
			}
			if (other.IsActive != 0)
			{
				this.IsActive = other.IsActive;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060184AE RID: 99502 RVA: 0x0038908C File Offset: 0x0038728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060184AF RID: 99503 RVA: 0x00389098 File Offset: 0x00387298
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
				if (num != 8U)
				{
					if (num != 24U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FanEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.BaoziEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.IsActive = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008FE3 RID: 36835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FE4 RID: 36836
		public const int FanEntityIdFieldNumber = 7;

		// Token: 0x04008FE5 RID: 36837
		private long fanEntityId_;

		// Token: 0x04008FE6 RID: 36838
		public const int BaoziEntityIdFieldNumber = 3;

		// Token: 0x04008FE7 RID: 36839
		private long baoziEntityId_;

		// Token: 0x04008FE8 RID: 36840
		public const int IsActiveFieldNumber = 1;

		// Token: 0x04008FE9 RID: 36841
		private int isActive_;
	}
}
