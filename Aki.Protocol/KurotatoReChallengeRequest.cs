using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AD RID: 2221
	[NetMessage(EMessageId.KurotatoReChallengeRequest)]
	public sealed class KurotatoReChallengeRequest : IMessage<KurotatoReChallengeRequest>, IMessage, IEquatable<KurotatoReChallengeRequest>, IDeepCloneable<KurotatoReChallengeRequest>, IBufferMessage
	{
		// Token: 0x0600C531 RID: 50481 RVA: 0x001D33F0 File Offset: 0x001D15F0
		[NullableContext(1)]
		public static KurotatoReChallengeRequest Create()
		{
			return new KurotatoReChallengeRequest();
		}

		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x0600C532 RID: 50482 RVA: 0x001D33F7 File Offset: 0x001D15F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x0600C533 RID: 50483 RVA: 0x001D33FA File Offset: 0x001D15FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoReChallengeRequest.Descriptor;
			}
		}

		// Token: 0x0600C534 RID: 50484 RVA: 0x001D3401 File Offset: 0x001D1601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeRequest()
		{
		}

		// Token: 0x0600C535 RID: 50485 RVA: 0x001D3409 File Offset: 0x001D1609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeRequest(KurotatoReChallengeRequest other) : this()
		{
			this.isFromCurWave_ = other.isFromCurWave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C536 RID: 50486 RVA: 0x001D342E File Offset: 0x001D162E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeRequest Clone()
		{
			return new KurotatoReChallengeRequest(this);
		}

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x0600C537 RID: 50487 RVA: 0x001D3436 File Offset: 0x001D1636
		// (set) Token: 0x0600C538 RID: 50488 RVA: 0x001D343E File Offset: 0x001D163E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFromCurWave
		{
			get
			{
				return this.isFromCurWave_;
			}
			set
			{
				this.isFromCurWave_ = value;
			}
		}

		// Token: 0x0600C539 RID: 50489 RVA: 0x001D3447 File Offset: 0x001D1647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoReChallengeRequest);
		}

		// Token: 0x0600C53A RID: 50490 RVA: 0x001D3455 File Offset: 0x001D1655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoReChallengeRequest other)
		{
			return other != null && (other == this || (this.IsFromCurWave == other.IsFromCurWave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C53B RID: 50491 RVA: 0x001D3484 File Offset: 0x001D1684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsFromCurWave)
			{
				num ^= this.IsFromCurWave.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C53C RID: 50492 RVA: 0x001D34C3 File Offset: 0x001D16C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C53D RID: 50493 RVA: 0x001D34D0 File Offset: 0x001D16D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C53E RID: 50494 RVA: 0x001D34D9 File Offset: 0x001D16D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFromCurWave)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsFromCurWave);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C53F RID: 50495 RVA: 0x001D350C File Offset: 0x001D170C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsFromCurWave)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C540 RID: 50496 RVA: 0x001D353E File Offset: 0x001D173E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoReChallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsFromCurWave)
			{
				this.IsFromCurWave = other.IsFromCurWave;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C541 RID: 50497 RVA: 0x001D356F File Offset: 0x001D176F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C542 RID: 50498 RVA: 0x001D3578 File Offset: 0x001D1778
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsFromCurWave = input.ReadBool();
				}
			}
		}

		// Token: 0x040054E9 RID: 21737
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054EA RID: 21738
		public const int IsFromCurWaveFieldNumber = 14;

		// Token: 0x040054EB RID: 21739
		private bool isFromCurWave_;
	}
}
