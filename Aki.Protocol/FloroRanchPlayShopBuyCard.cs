using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CD RID: 1485
	public sealed class FloroRanchPlayShopBuyCard : IMessage<FloroRanchPlayShopBuyCard>, IMessage, IEquatable<FloroRanchPlayShopBuyCard>, IDeepCloneable<FloroRanchPlayShopBuyCard>, IBufferMessage
	{
		// Token: 0x0600894A RID: 35146 RVA: 0x0014B17D File Offset: 0x0014937D
		[NullableContext(1)]
		public static FloroRanchPlayShopBuyCard Create()
		{
			return new FloroRanchPlayShopBuyCard();
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x0600894B RID: 35147 RVA: 0x0014B184 File Offset: 0x00149384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x0600894C RID: 35148 RVA: 0x0014B187 File Offset: 0x00149387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayShopBuyCard.Descriptor;
			}
		}

		// Token: 0x0600894D RID: 35149 RVA: 0x0014B18E File Offset: 0x0014938E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCard()
		{
		}

		// Token: 0x0600894E RID: 35150 RVA: 0x0014B196 File Offset: 0x00149396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCard(FloroRanchPlayShopBuyCard other) : this()
		{
			this.newPhantom_ = ((other.newPhantom_ != null) ? other.newPhantom_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600894F RID: 35151 RVA: 0x0014B1CB File Offset: 0x001493CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCard Clone()
		{
			return new FloroRanchPlayShopBuyCard(this);
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x06008950 RID: 35152 RVA: 0x0014B1D3 File Offset: 0x001493D3
		// (set) Token: 0x06008951 RID: 35153 RVA: 0x0014B1DB File Offset: 0x001493DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit NewPhantom
		{
			get
			{
				return this.newPhantom_;
			}
			set
			{
				this.newPhantom_ = value;
			}
		}

		// Token: 0x06008952 RID: 35154 RVA: 0x0014B1E4 File Offset: 0x001493E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayShopBuyCard);
		}

		// Token: 0x06008953 RID: 35155 RVA: 0x0014B1F2 File Offset: 0x001493F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayShopBuyCard other)
		{
			return other != null && (other == this || (object.Equals(this.NewPhantom, other.NewPhantom) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008954 RID: 35156 RVA: 0x0014B228 File Offset: 0x00149428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.newPhantom_ != null)
			{
				num ^= this.NewPhantom.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008955 RID: 35157 RVA: 0x0014B264 File Offset: 0x00149464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008956 RID: 35158 RVA: 0x0014B271 File Offset: 0x00149471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008957 RID: 35159 RVA: 0x0014B27A File Offset: 0x0014947A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newPhantom_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NewPhantom);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008958 RID: 35160 RVA: 0x0014B2AC File Offset: 0x001494AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.newPhantom_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewPhantom);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008959 RID: 35161 RVA: 0x0014B2EC File Offset: 0x001494EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayShopBuyCard other)
		{
			if (other == null)
			{
				return;
			}
			if (other.newPhantom_ != null)
			{
				if (this.newPhantom_ == null)
				{
					this.NewPhantom = new FloroRanchPlayUnit();
				}
				this.NewPhantom.MergeFrom(other.NewPhantom);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600895A RID: 35162 RVA: 0x0014B340 File Offset: 0x00149540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600895B RID: 35163 RVA: 0x0014B34C File Offset: 0x0014954C
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
					if (this.newPhantom_ == null)
					{
						this.NewPhantom = new FloroRanchPlayUnit();
					}
					input.ReadMessage(this.NewPhantom);
				}
			}
		}

		// Token: 0x0400438A RID: 17290
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400438B RID: 17291
		public const int NewPhantomFieldNumber = 1;

		// Token: 0x0400438C RID: 17292
		private FloroRanchPlayUnit newPhantom_;
	}
}
