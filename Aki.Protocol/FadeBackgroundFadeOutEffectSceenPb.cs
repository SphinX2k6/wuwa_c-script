using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000501 RID: 1281
	public sealed class FadeBackgroundFadeOutEffectSceenPb : IMessage<FadeBackgroundFadeOutEffectSceenPb>, IMessage, IEquatable<FadeBackgroundFadeOutEffectSceenPb>, IDeepCloneable<FadeBackgroundFadeOutEffectSceenPb>, IBufferMessage
	{
		// Token: 0x06007905 RID: 30981 RVA: 0x00126AD1 File Offset: 0x00124CD1
		[NullableContext(1)]
		public static FadeBackgroundFadeOutEffectSceenPb Create()
		{
			return new FadeBackgroundFadeOutEffectSceenPb();
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06007906 RID: 30982 RVA: 0x00126AD8 File Offset: 0x00124CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06007907 RID: 30983 RVA: 0x00126ADB File Offset: 0x00124CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeOutEffectSceenPb.Descriptor;
			}
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x00126AE2 File Offset: 0x00124CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectSceenPb()
		{
		}

		// Token: 0x06007909 RID: 30985 RVA: 0x00126AF5 File Offset: 0x00124CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectSceenPb(FadeBackgroundFadeOutEffectSceenPb other) : this()
		{
			this.screenEffect_ = other.screenEffect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x00126B1A File Offset: 0x00124D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectSceenPb Clone()
		{
			return new FadeBackgroundFadeOutEffectSceenPb(this);
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x0600790B RID: 30987 RVA: 0x00126B22 File Offset: 0x00124D22
		// (set) Token: 0x0600790C RID: 30988 RVA: 0x00126B2A File Offset: 0x00124D2A
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

		// Token: 0x0600790D RID: 30989 RVA: 0x00126B3D File Offset: 0x00124D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeOutEffectSceenPb);
		}

		// Token: 0x0600790E RID: 30990 RVA: 0x00126B4B File Offset: 0x00124D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeOutEffectSceenPb other)
		{
			return other != null && (other == this || (!(this.ScreenEffect != other.ScreenEffect) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x00126B80 File Offset: 0x00124D80
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

		// Token: 0x06007910 RID: 30992 RVA: 0x00126BC1 File Offset: 0x00124DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x00126BCE File Offset: 0x00124DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x00126BD7 File Offset: 0x00124DD7
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

		// Token: 0x06007913 RID: 30995 RVA: 0x00126C10 File Offset: 0x00124E10
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

		// Token: 0x06007914 RID: 30996 RVA: 0x00126C53 File Offset: 0x00124E53
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

		// Token: 0x06007915 RID: 30997 RVA: 0x00126C89 File Offset: 0x00124E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x00126C94 File Offset: 0x00124E94
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

		// Token: 0x04003EE4 RID: 16100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EE5 RID: 16101
		public const int ScreenEffectFieldNumber = 1;

		// Token: 0x04003EE6 RID: 16102
		private string screenEffect_ = "";
	}
}
