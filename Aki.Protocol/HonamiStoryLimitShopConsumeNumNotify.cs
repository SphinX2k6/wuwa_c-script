using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000773 RID: 1907
	[NetMessage(EMessageId.HonamiStoryLimitShopConsumeNumNotify)]
	public sealed class HonamiStoryLimitShopConsumeNumNotify : IMessage<HonamiStoryLimitShopConsumeNumNotify>, IMessage, IEquatable<HonamiStoryLimitShopConsumeNumNotify>, IDeepCloneable<HonamiStoryLimitShopConsumeNumNotify>, IBufferMessage
	{
		// Token: 0x0600ACBD RID: 44221 RVA: 0x0019FBE7 File Offset: 0x0019DDE7
		[NullableContext(1)]
		public static HonamiStoryLimitShopConsumeNumNotify Create()
		{
			return new HonamiStoryLimitShopConsumeNumNotify();
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x0600ACBE RID: 44222 RVA: 0x0019FBEE File Offset: 0x0019DDEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x0600ACBF RID: 44223 RVA: 0x0019FBF1 File Offset: 0x0019DDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLimitShopConsumeNumNotify.Descriptor;
			}
		}

		// Token: 0x0600ACC0 RID: 44224 RVA: 0x0019FBF8 File Offset: 0x0019DDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitShopConsumeNumNotify()
		{
		}

		// Token: 0x0600ACC1 RID: 44225 RVA: 0x0019FC00 File Offset: 0x0019DE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitShopConsumeNumNotify(HonamiStoryLimitShopConsumeNumNotify other) : this()
		{
			this.limitItemConsumeNum_ = other.limitItemConsumeNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACC2 RID: 44226 RVA: 0x0019FC25 File Offset: 0x0019DE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitShopConsumeNumNotify Clone()
		{
			return new HonamiStoryLimitShopConsumeNumNotify(this);
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x0600ACC3 RID: 44227 RVA: 0x0019FC2D File Offset: 0x0019DE2D
		// (set) Token: 0x0600ACC4 RID: 44228 RVA: 0x0019FC35 File Offset: 0x0019DE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitItemConsumeNum
		{
			get
			{
				return this.limitItemConsumeNum_;
			}
			set
			{
				this.limitItemConsumeNum_ = value;
			}
		}

		// Token: 0x0600ACC5 RID: 44229 RVA: 0x0019FC3E File Offset: 0x0019DE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLimitShopConsumeNumNotify);
		}

		// Token: 0x0600ACC6 RID: 44230 RVA: 0x0019FC4C File Offset: 0x0019DE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLimitShopConsumeNumNotify other)
		{
			return other != null && (other == this || (this.LimitItemConsumeNum == other.LimitItemConsumeNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACC7 RID: 44231 RVA: 0x0019FC7C File Offset: 0x0019DE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LimitItemConsumeNum != 0)
			{
				num ^= this.LimitItemConsumeNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ACC8 RID: 44232 RVA: 0x0019FCBB File Offset: 0x0019DEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ACC9 RID: 44233 RVA: 0x0019FCC8 File Offset: 0x0019DEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACCA RID: 44234 RVA: 0x0019FCD1 File Offset: 0x0019DED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LimitItemConsumeNum != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.LimitItemConsumeNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACCB RID: 44235 RVA: 0x0019FD04 File Offset: 0x0019DF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LimitItemConsumeNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitItemConsumeNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ACCC RID: 44236 RVA: 0x0019FD42 File Offset: 0x0019DF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLimitShopConsumeNumNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LimitItemConsumeNum != 0)
			{
				this.LimitItemConsumeNum = other.LimitItemConsumeNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ACCD RID: 44237 RVA: 0x0019FD73 File Offset: 0x0019DF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACCE RID: 44238 RVA: 0x0019FD7C File Offset: 0x0019DF7C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LimitItemConsumeNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E9C RID: 20124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E9D RID: 20125
		public const int LimitItemConsumeNumFieldNumber = 15;

		// Token: 0x04004E9E RID: 20126
		private int limitItemConsumeNum_;
	}
}
