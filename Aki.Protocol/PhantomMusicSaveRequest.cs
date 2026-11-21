using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDA RID: 3290
	[NetMessage(EMessageId.PhantomMusicSaveRequest)]
	public sealed class PhantomMusicSaveRequest : IMessage<PhantomMusicSaveRequest>, IMessage, IEquatable<PhantomMusicSaveRequest>, IDeepCloneable<PhantomMusicSaveRequest>, IBufferMessage
	{
		// Token: 0x06011D26 RID: 72998 RVA: 0x0029BF8D File Offset: 0x0029A18D
		[NullableContext(1)]
		public static PhantomMusicSaveRequest Create()
		{
			return new PhantomMusicSaveRequest();
		}

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x06011D27 RID: 72999 RVA: 0x0029BF94 File Offset: 0x0029A194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x06011D28 RID: 73000 RVA: 0x0029BF97 File Offset: 0x0029A197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicSaveRequest.Descriptor;
			}
		}

		// Token: 0x06011D29 RID: 73001 RVA: 0x0029BF9E File Offset: 0x0029A19E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveRequest()
		{
		}

		// Token: 0x06011D2A RID: 73002 RVA: 0x0029BFA6 File Offset: 0x0029A1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveRequest(PhantomMusicSaveRequest other) : this()
		{
			this.music_ = other.music_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D2B RID: 73003 RVA: 0x0029BFCB File Offset: 0x0029A1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveRequest Clone()
		{
			return new PhantomMusicSaveRequest(this);
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x06011D2C RID: 73004 RVA: 0x0029BFD3 File Offset: 0x0029A1D3
		// (set) Token: 0x06011D2D RID: 73005 RVA: 0x0029BFDB File Offset: 0x0029A1DB
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

		// Token: 0x06011D2E RID: 73006 RVA: 0x0029BFE4 File Offset: 0x0029A1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicSaveRequest);
		}

		// Token: 0x06011D2F RID: 73007 RVA: 0x0029BFF2 File Offset: 0x0029A1F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicSaveRequest other)
		{
			return other != null && (other == this || (this.Music == other.Music && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D30 RID: 73008 RVA: 0x0029C020 File Offset: 0x0029A220
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

		// Token: 0x06011D31 RID: 73009 RVA: 0x0029C05F File Offset: 0x0029A25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D32 RID: 73010 RVA: 0x0029C06C File Offset: 0x0029A26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D33 RID: 73011 RVA: 0x0029C075 File Offset: 0x0029A275
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

		// Token: 0x06011D34 RID: 73012 RVA: 0x0029C0A8 File Offset: 0x0029A2A8
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

		// Token: 0x06011D35 RID: 73013 RVA: 0x0029C0E6 File Offset: 0x0029A2E6
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

		// Token: 0x06011D36 RID: 73014 RVA: 0x0029C117 File Offset: 0x0029A317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D37 RID: 73015 RVA: 0x0029C120 File Offset: 0x0029A320
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

		// Token: 0x04007054 RID: 28756
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007055 RID: 28757
		public const int MusicFieldNumber = 5;

		// Token: 0x04007056 RID: 28758
		private int music_;
	}
}
