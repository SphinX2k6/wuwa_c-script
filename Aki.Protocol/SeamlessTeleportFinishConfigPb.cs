using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A5 RID: 4517
	public sealed class SeamlessTeleportFinishConfigPb : IMessage<SeamlessTeleportFinishConfigPb>, IMessage, IEquatable<SeamlessTeleportFinishConfigPb>, IDeepCloneable<SeamlessTeleportFinishConfigPb>, IBufferMessage
	{
		// Token: 0x0601811A RID: 98586 RVA: 0x0037EC70 File Offset: 0x0037CE70
		[NullableContext(1)]
		public static SeamlessTeleportFinishConfigPb Create()
		{
			return new SeamlessTeleportFinishConfigPb();
		}

		// Token: 0x170050E5 RID: 20709
		// (get) Token: 0x0601811B RID: 98587 RVA: 0x0037EC77 File Offset: 0x0037CE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050E6 RID: 20710
		// (get) Token: 0x0601811C RID: 98588 RVA: 0x0037EC7A File Offset: 0x0037CE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportFinishConfigPb.Descriptor;
			}
		}

		// Token: 0x0601811D RID: 98589 RVA: 0x0037EC81 File Offset: 0x0037CE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportFinishConfigPb()
		{
		}

		// Token: 0x0601811E RID: 98590 RVA: 0x0037EC89 File Offset: 0x0037CE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportFinishConfigPb(SeamlessTeleportFinishConfigPb other) : this()
		{
			this.isNotStopScreenEffect_ = other.isNotStopScreenEffect_;
			this.effectExtraState_ = other.effectExtraState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601811F RID: 98591 RVA: 0x0037ECBA File Offset: 0x0037CEBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportFinishConfigPb Clone()
		{
			return new SeamlessTeleportFinishConfigPb(this);
		}

		// Token: 0x170050E7 RID: 20711
		// (get) Token: 0x06018120 RID: 98592 RVA: 0x0037ECC2 File Offset: 0x0037CEC2
		// (set) Token: 0x06018121 RID: 98593 RVA: 0x0037ECCA File Offset: 0x0037CECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNotStopScreenEffect
		{
			get
			{
				return this.isNotStopScreenEffect_;
			}
			set
			{
				this.isNotStopScreenEffect_ = value;
			}
		}

		// Token: 0x170050E8 RID: 20712
		// (get) Token: 0x06018122 RID: 98594 RVA: 0x0037ECD3 File Offset: 0x0037CED3
		// (set) Token: 0x06018123 RID: 98595 RVA: 0x0037ECDB File Offset: 0x0037CEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectExtraState
		{
			get
			{
				return this.effectExtraState_;
			}
			set
			{
				this.effectExtraState_ = value;
			}
		}

		// Token: 0x06018124 RID: 98596 RVA: 0x0037ECE4 File Offset: 0x0037CEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportFinishConfigPb);
		}

		// Token: 0x06018125 RID: 98597 RVA: 0x0037ECF2 File Offset: 0x0037CEF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportFinishConfigPb other)
		{
			return other != null && (other == this || (this.IsNotStopScreenEffect == other.IsNotStopScreenEffect && this.EffectExtraState == other.EffectExtraState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018126 RID: 98598 RVA: 0x0037ED30 File Offset: 0x0037CF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsNotStopScreenEffect)
			{
				num ^= this.IsNotStopScreenEffect.GetHashCode();
			}
			if (this.EffectExtraState != 0)
			{
				num ^= this.EffectExtraState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018127 RID: 98599 RVA: 0x0037ED88 File Offset: 0x0037CF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018128 RID: 98600 RVA: 0x0037ED95 File Offset: 0x0037CF95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018129 RID: 98601 RVA: 0x0037EDA0 File Offset: 0x0037CFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNotStopScreenEffect)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsNotStopScreenEffect);
			}
			if (this.EffectExtraState != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EffectExtraState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601812A RID: 98602 RVA: 0x0037EDF8 File Offset: 0x0037CFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsNotStopScreenEffect)
			{
				num += 2;
			}
			if (this.EffectExtraState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectExtraState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601812B RID: 98603 RVA: 0x0037EE44 File Offset: 0x0037D044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeamlessTeleportFinishConfigPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsNotStopScreenEffect)
			{
				this.IsNotStopScreenEffect = other.IsNotStopScreenEffect;
			}
			if (other.EffectExtraState != 0)
			{
				this.EffectExtraState = other.EffectExtraState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601812C RID: 98604 RVA: 0x0037EE94 File Offset: 0x0037D094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601812D RID: 98605 RVA: 0x0037EEA0 File Offset: 0x0037D0A0
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EffectExtraState = input.ReadInt32();
					}
				}
				else
				{
					this.IsNotStopScreenEffect = input.ReadBool();
				}
			}
		}

		// Token: 0x04008E7A RID: 36474
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E7B RID: 36475
		public const int IsNotStopScreenEffectFieldNumber = 1;

		// Token: 0x04008E7C RID: 36476
		private bool isNotStopScreenEffect_;

		// Token: 0x04008E7D RID: 36477
		public const int EffectExtraStateFieldNumber = 2;

		// Token: 0x04008E7E RID: 36478
		private int effectExtraState_;
	}
}
