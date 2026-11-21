using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DF RID: 4575
	public sealed class SeamlessTeleportFinishConfigPb : IMessage<SeamlessTeleportFinishConfigPb>, IMessage, IEquatable<SeamlessTeleportFinishConfigPb>, IDeepCloneable<SeamlessTeleportFinishConfigPb>, IBufferMessage
	{
		// Token: 0x060186BB RID: 100027 RVA: 0x0038DFB4 File Offset: 0x0038C1B4
		[NullableContext(1)]
		public static SeamlessTeleportFinishConfigPb Create()
		{
			return new SeamlessTeleportFinishConfigPb();
		}

		// Token: 0x17005251 RID: 21073
		// (get) Token: 0x060186BC RID: 100028 RVA: 0x0038DFBB File Offset: 0x0038C1BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005252 RID: 21074
		// (get) Token: 0x060186BD RID: 100029 RVA: 0x0038DFBE File Offset: 0x0038C1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportFinishConfigPb.Descriptor;
			}
		}

		// Token: 0x060186BE RID: 100030 RVA: 0x0038DFC5 File Offset: 0x0038C1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportFinishConfigPb()
		{
		}

		// Token: 0x060186BF RID: 100031 RVA: 0x0038DFCD File Offset: 0x0038C1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportFinishConfigPb(SeamlessTeleportFinishConfigPb other) : this()
		{
			this.isNotStopScreenEffect_ = other.isNotStopScreenEffect_;
			this.effectExtraState_ = other.effectExtraState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060186C0 RID: 100032 RVA: 0x0038DFFE File Offset: 0x0038C1FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportFinishConfigPb Clone()
		{
			return new SeamlessTeleportFinishConfigPb(this);
		}

		// Token: 0x17005253 RID: 21075
		// (get) Token: 0x060186C1 RID: 100033 RVA: 0x0038E006 File Offset: 0x0038C206
		// (set) Token: 0x060186C2 RID: 100034 RVA: 0x0038E00E File Offset: 0x0038C20E
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

		// Token: 0x17005254 RID: 21076
		// (get) Token: 0x060186C3 RID: 100035 RVA: 0x0038E017 File Offset: 0x0038C217
		// (set) Token: 0x060186C4 RID: 100036 RVA: 0x0038E01F File Offset: 0x0038C21F
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

		// Token: 0x060186C5 RID: 100037 RVA: 0x0038E028 File Offset: 0x0038C228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportFinishConfigPb);
		}

		// Token: 0x060186C6 RID: 100038 RVA: 0x0038E036 File Offset: 0x0038C236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportFinishConfigPb other)
		{
			return other != null && (other == this || (this.IsNotStopScreenEffect == other.IsNotStopScreenEffect && this.EffectExtraState == other.EffectExtraState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060186C7 RID: 100039 RVA: 0x0038E074 File Offset: 0x0038C274
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

		// Token: 0x060186C8 RID: 100040 RVA: 0x0038E0CC File Offset: 0x0038C2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060186C9 RID: 100041 RVA: 0x0038E0D9 File Offset: 0x0038C2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060186CA RID: 100042 RVA: 0x0038E0E4 File Offset: 0x0038C2E4
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

		// Token: 0x060186CB RID: 100043 RVA: 0x0038E13C File Offset: 0x0038C33C
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

		// Token: 0x060186CC RID: 100044 RVA: 0x0038E188 File Offset: 0x0038C388
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

		// Token: 0x060186CD RID: 100045 RVA: 0x0038E1D8 File Offset: 0x0038C3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060186CE RID: 100046 RVA: 0x0038E1E4 File Offset: 0x0038C3E4
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

		// Token: 0x0400910D RID: 37133
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400910E RID: 37134
		public const int IsNotStopScreenEffectFieldNumber = 1;

		// Token: 0x0400910F RID: 37135
		private bool isNotStopScreenEffect_;

		// Token: 0x04009110 RID: 37136
		public const int EffectExtraStateFieldNumber = 2;

		// Token: 0x04009111 RID: 37137
		private int effectExtraState_;
	}
}
