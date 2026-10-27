using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CEA RID: 3306
	[NetMessage(EMessageId.PhantomMusicSaveRequest)]
	public sealed class PhantomMusicSaveRequest : IMessage<PhantomMusicSaveRequest>, IMessage, IEquatable<PhantomMusicSaveRequest>, IDeepCloneable<PhantomMusicSaveRequest>, IBufferMessage
	{
		// Token: 0x06011E22 RID: 73250 RVA: 0x0029DBA4 File Offset: 0x0029BDA4
		[NullableContext(1)]
		public static PhantomMusicSaveRequest Create()
		{
			return new PhantomMusicSaveRequest();
		}

		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x06011E23 RID: 73251 RVA: 0x0029DBAB File Offset: 0x0029BDAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x06011E24 RID: 73252 RVA: 0x0029DBAE File Offset: 0x0029BDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicSaveRequest.Descriptor;
			}
		}

		// Token: 0x06011E25 RID: 73253 RVA: 0x0029DBB5 File Offset: 0x0029BDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveRequest()
		{
		}

		// Token: 0x06011E26 RID: 73254 RVA: 0x0029DBBD File Offset: 0x0029BDBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveRequest(PhantomMusicSaveRequest other) : this()
		{
			this.music_ = other.music_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E27 RID: 73255 RVA: 0x0029DBE2 File Offset: 0x0029BDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveRequest Clone()
		{
			return new PhantomMusicSaveRequest(this);
		}

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x06011E28 RID: 73256 RVA: 0x0029DBEA File Offset: 0x0029BDEA
		// (set) Token: 0x06011E29 RID: 73257 RVA: 0x0029DBF2 File Offset: 0x0029BDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Music
		{
			get
			{
				return this.music_;
			}
			set
			{
				this.music_ = value;
			}
		}

		// Token: 0x06011E2A RID: 73258 RVA: 0x0029DBFB File Offset: 0x0029BDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicSaveRequest);
		}

		// Token: 0x06011E2B RID: 73259 RVA: 0x0029DC09 File Offset: 0x0029BE09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicSaveRequest other)
		{
			return other != null && (other == this || (this.Music == other.Music && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E2C RID: 73260 RVA: 0x0029DC38 File Offset: 0x0029BE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Music != 0)
			{
				num ^= this.Music.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011E2D RID: 73261 RVA: 0x0029DC77 File Offset: 0x0029BE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E2E RID: 73262 RVA: 0x0029DC84 File Offset: 0x0029BE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E2F RID: 73263 RVA: 0x0029DC8D File Offset: 0x0029BE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Music != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Music);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E30 RID: 73264 RVA: 0x0029DCC0 File Offset: 0x0029BEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Music != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Music);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011E31 RID: 73265 RVA: 0x0029DCFE File Offset: 0x0029BEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicSaveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Music != 0)
			{
				this.Music = other.Music;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011E32 RID: 73266 RVA: 0x0029DD2F File Offset: 0x0029BF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E33 RID: 73267 RVA: 0x0029DD38 File Offset: 0x0029BF38
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Music = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400703C RID: 28732
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400703D RID: 28733
		public const int MusicFieldNumber = 5;

		// Token: 0x0400703E RID: 28734
		private int music_;
	}
}
