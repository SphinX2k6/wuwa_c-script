using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000517 RID: 1303
	public sealed class FadeBackgroundFadeOutEffectSceenPb : IMessage<FadeBackgroundFadeOutEffectSceenPb>, IMessage, IEquatable<FadeBackgroundFadeOutEffectSceenPb>, IDeepCloneable<FadeBackgroundFadeOutEffectSceenPb>, IBufferMessage
	{
		// Token: 0x06007A81 RID: 31361 RVA: 0x00129965 File Offset: 0x00127B65
		[NullableContext(1)]
		public static FadeBackgroundFadeOutEffectSceenPb Create()
		{
			return new FadeBackgroundFadeOutEffectSceenPb();
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06007A82 RID: 31362 RVA: 0x0012996C File Offset: 0x00127B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06007A83 RID: 31363 RVA: 0x0012996F File Offset: 0x00127B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeOutEffectSceenPb.Descriptor;
			}
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x00129976 File Offset: 0x00127B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectSceenPb()
		{
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x00129989 File Offset: 0x00127B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectSceenPb(FadeBackgroundFadeOutEffectSceenPb other) : this()
		{
			this.screenEffect_ = other.screenEffect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x001299AE File Offset: 0x00127BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectSceenPb Clone()
		{
			return new FadeBackgroundFadeOutEffectSceenPb(this);
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06007A87 RID: 31367 RVA: 0x001299B6 File Offset: 0x00127BB6
		// (set) Token: 0x06007A88 RID: 31368 RVA: 0x001299BE File Offset: 0x00127BBE
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

		// Token: 0x06007A89 RID: 31369 RVA: 0x001299D1 File Offset: 0x00127BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeOutEffectSceenPb);
		}

		// Token: 0x06007A8A RID: 31370 RVA: 0x001299DF File Offset: 0x00127BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeOutEffectSceenPb other)
		{
			return other != null && (other == this || (!(this.ScreenEffect != other.ScreenEffect) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A8B RID: 31371 RVA: 0x00129A14 File Offset: 0x00127C14
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

		// Token: 0x06007A8C RID: 31372 RVA: 0x00129A55 File Offset: 0x00127C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x00129A62 File Offset: 0x00127C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A8E RID: 31374 RVA: 0x00129A6B File Offset: 0x00127C6B
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

		// Token: 0x06007A8F RID: 31375 RVA: 0x00129AA4 File Offset: 0x00127CA4
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

		// Token: 0x06007A90 RID: 31376 RVA: 0x00129AE7 File Offset: 0x00127CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FadeBackgroundFadeOutEffectSceenPb other)
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

		// Token: 0x06007A91 RID: 31377 RVA: 0x00129B1D File Offset: 0x00127D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A92 RID: 31378 RVA: 0x00129B28 File Offset: 0x00127D28
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

		// Token: 0x04003EF3 RID: 16115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EF4 RID: 16116
		public const int ScreenEffectFieldNumber = 1;

		// Token: 0x04003EF5 RID: 16117
		private string screenEffect_ = "";
	}
}
