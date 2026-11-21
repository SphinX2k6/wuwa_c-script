using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D7 RID: 2519
	[NetMessage(EMessageId.ModifyBulletParamsPush)]
	public sealed class ModifyBulletParamsPush : IMessage<ModifyBulletParamsPush>, IMessage, IEquatable<ModifyBulletParamsPush>, IDeepCloneable<ModifyBulletParamsPush>, IBufferMessage
	{
		// Token: 0x0600DD19 RID: 56601 RVA: 0x002075E4 File Offset: 0x002057E4
		[NullableContext(1)]
		public static ModifyBulletParamsPush Create()
		{
			return new ModifyBulletParamsPush();
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x0600DD1A RID: 56602 RVA: 0x002075EB File Offset: 0x002057EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x0600DD1B RID: 56603 RVA: 0x002075EE File Offset: 0x002057EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyBulletParamsPush.Descriptor;
			}
		}

		// Token: 0x0600DD1C RID: 56604 RVA: 0x002075F5 File Offset: 0x002057F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsPush()
		{
		}

		// Token: 0x0600DD1D RID: 56605 RVA: 0x002075FD File Offset: 0x002057FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsPush(ModifyBulletParamsPush other) : this()
		{
			this.modifyBulletParams_ = ((other.modifyBulletParams_ != null) ? other.modifyBulletParams_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD1E RID: 56606 RVA: 0x00207632 File Offset: 0x00205832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsPush Clone()
		{
			return new ModifyBulletParamsPush(this);
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x0600DD1F RID: 56607 RVA: 0x0020763A File Offset: 0x0020583A
		// (set) Token: 0x0600DD20 RID: 56608 RVA: 0x00207642 File Offset: 0x00205842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParams ModifyBulletParams
		{
			get
			{
				return this.modifyBulletParams_;
			}
			set
			{
				this.modifyBulletParams_ = value;
			}
		}

		// Token: 0x0600DD21 RID: 56609 RVA: 0x0020764B File Offset: 0x0020584B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyBulletParamsPush);
		}

		// Token: 0x0600DD22 RID: 56610 RVA: 0x00207659 File Offset: 0x00205859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyBulletParamsPush other)
		{
			return other != null && (other == this || (object.Equals(this.ModifyBulletParams, other.ModifyBulletParams) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD23 RID: 56611 RVA: 0x0020768C File Offset: 0x0020588C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.modifyBulletParams_ != null)
			{
				num ^= this.ModifyBulletParams.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD24 RID: 56612 RVA: 0x002076C8 File Offset: 0x002058C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD25 RID: 56613 RVA: 0x002076D5 File Offset: 0x002058D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD26 RID: 56614 RVA: 0x002076DE File Offset: 0x002058DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.modifyBulletParams_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ModifyBulletParams);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD27 RID: 56615 RVA: 0x00207710 File Offset: 0x00205910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.modifyBulletParams_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ModifyBulletParams);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD28 RID: 56616 RVA: 0x00207750 File Offset: 0x00205950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyBulletParamsPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.modifyBulletParams_ != null)
			{
				if (this.modifyBulletParams_ == null)
				{
					this.ModifyBulletParams = new ModifyBulletParams();
				}
				this.ModifyBulletParams.MergeFrom(other.ModifyBulletParams);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD29 RID: 56617 RVA: 0x002077A4 File Offset: 0x002059A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD2A RID: 56618 RVA: 0x002077B0 File Offset: 0x002059B0
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.modifyBulletParams_ == null)
					{
						this.ModifyBulletParams = new ModifyBulletParams();
					}
					input.ReadMessage(this.ModifyBulletParams);
				}
			}
		}

		// Token: 0x04005BD3 RID: 23507
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BD4 RID: 23508
		public const int ModifyBulletParamsFieldNumber = 1;

		// Token: 0x04005BD5 RID: 23509
		private ModifyBulletParams modifyBulletParams_;
	}
}
