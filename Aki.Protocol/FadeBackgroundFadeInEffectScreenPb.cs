using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FE RID: 1278
	public sealed class FadeBackgroundFadeInEffectScreenPb : IMessage<FadeBackgroundFadeInEffectScreenPb>, IMessage, IEquatable<FadeBackgroundFadeInEffectScreenPb>, IDeepCloneable<FadeBackgroundFadeInEffectScreenPb>, IBufferMessage
	{
		// Token: 0x060078C3 RID: 30915 RVA: 0x00126149 File Offset: 0x00124349
		[NullableContext(1)]
		public static FadeBackgroundFadeInEffectScreenPb Create()
		{
			return new FadeBackgroundFadeInEffectScreenPb();
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x060078C4 RID: 30916 RVA: 0x00126150 File Offset: 0x00124350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x060078C5 RID: 30917 RVA: 0x00126153 File Offset: 0x00124353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeInEffectScreenPb.Descriptor;
			}
		}

		// Token: 0x060078C6 RID: 30918 RVA: 0x0012615A File Offset: 0x0012435A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectScreenPb()
		{
		}

		// Token: 0x060078C7 RID: 30919 RVA: 0x0012616D File Offset: 0x0012436D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectScreenPb(FadeBackgroundFadeInEffectScreenPb other) : this()
		{
			this.screenEffect_ = other.screenEffect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078C8 RID: 30920 RVA: 0x00126192 File Offset: 0x00124392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectScreenPb Clone()
		{
			return new FadeBackgroundFadeInEffectScreenPb(this);
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x060078C9 RID: 30921 RVA: 0x0012619A File Offset: 0x0012439A
		// (set) Token: 0x060078CA RID: 30922 RVA: 0x001261A2 File Offset: 0x001243A2
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

		// Token: 0x060078CB RID: 30923 RVA: 0x001261B5 File Offset: 0x001243B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeInEffectScreenPb);
		}

		// Token: 0x060078CC RID: 30924 RVA: 0x001261C3 File Offset: 0x001243C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeInEffectScreenPb other)
		{
			return other != null && (other == this || (!(this.ScreenEffect != other.ScreenEffect) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078CD RID: 30925 RVA: 0x001261F8 File Offset: 0x001243F8
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

		// Token: 0x060078CE RID: 30926 RVA: 0x00126239 File Offset: 0x00124439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060078CF RID: 30927 RVA: 0x00126246 File Offset: 0x00124446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x0012624F File Offset: 0x0012444F
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

		// Token: 0x060078D1 RID: 30929 RVA: 0x00126288 File Offset: 0x00124488
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

		// Token: 0x060078D2 RID: 30930 RVA: 0x001262CB File Offset: 0x001244CB
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

		// Token: 0x060078D3 RID: 30931 RVA: 0x00126301 File Offset: 0x00124501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078D4 RID: 30932 RVA: 0x0012630C File Offset: 0x0012450C
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

		// Token: 0x04003ED2 RID: 16082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ED3 RID: 16083
		public const int ScreenEffectFieldNumber = 1;

		// Token: 0x04003ED4 RID: 16084
		private string screenEffect_ = "";
	}
}
