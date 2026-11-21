using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD9 RID: 3289
	[NetMessage(EMessageId.PhantomMusicNotify)]
	public sealed class PhantomMusicNotify : IMessage<PhantomMusicNotify>, IMessage, IEquatable<PhantomMusicNotify>, IDeepCloneable<PhantomMusicNotify>, IBufferMessage
	{
		// Token: 0x06011D14 RID: 72980 RVA: 0x0029BDB5 File Offset: 0x00299FB5
		[NullableContext(1)]
		public static PhantomMusicNotify Create()
		{
			return new PhantomMusicNotify();
		}

		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x06011D15 RID: 72981 RVA: 0x0029BDBC File Offset: 0x00299FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x06011D16 RID: 72982 RVA: 0x0029BDBF File Offset: 0x00299FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicNotify.Descriptor;
			}
		}

		// Token: 0x06011D17 RID: 72983 RVA: 0x0029BDC6 File Offset: 0x00299FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicNotify()
		{
		}

		// Token: 0x06011D18 RID: 72984 RVA: 0x0029BDCE File Offset: 0x00299FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicNotify(PhantomMusicNotify other) : this()
		{
			this.music_ = other.music_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D19 RID: 72985 RVA: 0x0029BDF3 File Offset: 0x00299FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicNotify Clone()
		{
			return new PhantomMusicNotify(this);
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x06011D1A RID: 72986 RVA: 0x0029BDFB File Offset: 0x00299FFB
		// (set) Token: 0x06011D1B RID: 72987 RVA: 0x0029BE03 File Offset: 0x0029A003
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

		// Token: 0x06011D1C RID: 72988 RVA: 0x0029BE0C File Offset: 0x0029A00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicNotify);
		}

		// Token: 0x06011D1D RID: 72989 RVA: 0x0029BE1A File Offset: 0x0029A01A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicNotify other)
		{
			return other != null && (other == this || (this.Music == other.Music && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D1E RID: 72990 RVA: 0x0029BE48 File Offset: 0x0029A048
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

		// Token: 0x06011D1F RID: 72991 RVA: 0x0029BE87 File Offset: 0x0029A087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D20 RID: 72992 RVA: 0x0029BE94 File Offset: 0x0029A094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D21 RID: 72993 RVA: 0x0029BE9D File Offset: 0x0029A09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Music != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Music);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D22 RID: 72994 RVA: 0x0029BED0 File Offset: 0x0029A0D0
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

		// Token: 0x06011D23 RID: 72995 RVA: 0x0029BF0E File Offset: 0x0029A10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicNotify other)
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

		// Token: 0x06011D24 RID: 72996 RVA: 0x0029BF3F File Offset: 0x0029A13F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D25 RID: 72997 RVA: 0x0029BF48 File Offset: 0x0029A148
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Music = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007051 RID: 28753
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007052 RID: 28754
		public const int MusicFieldNumber = 4;

		// Token: 0x04007053 RID: 28755
		private int music_;
	}
}
