using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000514 RID: 1300
	public sealed class FadeBackgroundFadeInEffectScreenPb : IMessage<FadeBackgroundFadeInEffectScreenPb>, IMessage, IEquatable<FadeBackgroundFadeInEffectScreenPb>, IDeepCloneable<FadeBackgroundFadeInEffectScreenPb>, IBufferMessage
	{
		// Token: 0x06007A3F RID: 31295 RVA: 0x00128FDD File Offset: 0x001271DD
		[NullableContext(1)]
		public static FadeBackgroundFadeInEffectScreenPb Create()
		{
			return new FadeBackgroundFadeInEffectScreenPb();
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06007A40 RID: 31296 RVA: 0x00128FE4 File Offset: 0x001271E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06007A41 RID: 31297 RVA: 0x00128FE7 File Offset: 0x001271E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeInEffectScreenPb.Descriptor;
			}
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x00128FEE File Offset: 0x001271EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectScreenPb()
		{
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x00129001 File Offset: 0x00127201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectScreenPb(FadeBackgroundFadeInEffectScreenPb other) : this()
		{
			this.screenEffect_ = other.screenEffect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A44 RID: 31300 RVA: 0x00129026 File Offset: 0x00127226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectScreenPb Clone()
		{
			return new FadeBackgroundFadeInEffectScreenPb(this);
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06007A45 RID: 31301 RVA: 0x0012902E File Offset: 0x0012722E
		// (set) Token: 0x06007A46 RID: 31302 RVA: 0x00129036 File Offset: 0x00127236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ScreenEffect
		{
			get
			{
				return this.screenEffect_;
			}
			set
			{
				this.screenEffect_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x00129049 File Offset: 0x00127249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeInEffectScreenPb);
		}

		// Token: 0x06007A48 RID: 31304 RVA: 0x00129057 File Offset: 0x00127257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeInEffectScreenPb other)
		{
			return other != null && (other == this || (!(this.ScreenEffect != other.ScreenEffect) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x0012908C File Offset: 0x0012728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScreenEffect.Length != 0)
			{
				num ^= this.ScreenEffect.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x001290CD File Offset: 0x001272CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x001290DA File Offset: 0x001272DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x001290E3 File Offset: 0x001272E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScreenEffect.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ScreenEffect);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x0012911C File Offset: 0x0012731C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScreenEffect.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ScreenEffect);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x0012915F File Offset: 0x0012735F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FadeBackgroundFadeInEffectScreenPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScreenEffect.Length != 0)
			{
				this.ScreenEffect = other.ScreenEffect;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x00129195 File Offset: 0x00127395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A50 RID: 31312 RVA: 0x001291A0 File Offset: 0x001273A0
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
					this.ScreenEffect = input.ReadString();
				}
			}
		}

		// Token: 0x04003EE1 RID: 16097
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EE2 RID: 16098
		public const int ScreenEffectFieldNumber = 1;

		// Token: 0x04003EE3 RID: 16099
		private string screenEffect_ = "";
	}
}
