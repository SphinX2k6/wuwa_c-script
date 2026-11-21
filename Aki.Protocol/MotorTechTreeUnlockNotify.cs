using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA0 RID: 2720
	[NetMessage(EMessageId.MotorTechTreeUnlockNotify)]
	public sealed class MotorTechTreeUnlockNotify : IMessage<MotorTechTreeUnlockNotify>, IMessage, IEquatable<MotorTechTreeUnlockNotify>, IDeepCloneable<MotorTechTreeUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600ED1B RID: 60699 RVA: 0x0022A1D7 File Offset: 0x002283D7
		[NullableContext(1)]
		public static MotorTechTreeUnlockNotify Create()
		{
			return new MotorTechTreeUnlockNotify();
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x0600ED1C RID: 60700 RVA: 0x0022A1DE File Offset: 0x002283DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x0600ED1D RID: 60701 RVA: 0x0022A1E1 File Offset: 0x002283E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechTreeUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600ED1E RID: 60702 RVA: 0x0022A1E8 File Offset: 0x002283E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeUnlockNotify()
		{
		}

		// Token: 0x0600ED1F RID: 60703 RVA: 0x0022A1F0 File Offset: 0x002283F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeUnlockNotify(MotorTechTreeUnlockNotify other) : this()
		{
			this.treeId_ = other.treeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED20 RID: 60704 RVA: 0x0022A215 File Offset: 0x00228415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeUnlockNotify Clone()
		{
			return new MotorTechTreeUnlockNotify(this);
		}

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x0600ED21 RID: 60705 RVA: 0x0022A21D File Offset: 0x0022841D
		// (set) Token: 0x0600ED22 RID: 60706 RVA: 0x0022A225 File Offset: 0x00228425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeId
		{
			get
			{
				return this.treeId_;
			}
			set
			{
				this.treeId_ = value;
			}
		}

		// Token: 0x0600ED23 RID: 60707 RVA: 0x0022A22E File Offset: 0x0022842E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechTreeUnlockNotify);
		}

		// Token: 0x0600ED24 RID: 60708 RVA: 0x0022A23C File Offset: 0x0022843C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechTreeUnlockNotify other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED25 RID: 60709 RVA: 0x0022A26C File Offset: 0x0022846C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ED26 RID: 60710 RVA: 0x0022A2AB File Offset: 0x002284AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED27 RID: 60711 RVA: 0x0022A2B8 File Offset: 0x002284B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED28 RID: 60712 RVA: 0x0022A2C1 File Offset: 0x002284C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED29 RID: 60713 RVA: 0x0022A2F4 File Offset: 0x002284F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ED2A RID: 60714 RVA: 0x0022A332 File Offset: 0x00228532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTechTreeUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ED2B RID: 60715 RVA: 0x0022A363 File Offset: 0x00228563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED2C RID: 60716 RVA: 0x0022A36C File Offset: 0x0022856C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TreeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400606D RID: 24685
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400606E RID: 24686
		public const int TreeIdFieldNumber = 13;

		// Token: 0x0400606F RID: 24687
		private int treeId_;
	}
}
