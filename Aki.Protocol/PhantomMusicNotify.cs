using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE9 RID: 3305
	[NetMessage(EMessageId.PhantomMusicNotify)]
	public sealed class PhantomMusicNotify : IMessage<PhantomMusicNotify>, IMessage, IEquatable<PhantomMusicNotify>, IDeepCloneable<PhantomMusicNotify>, IBufferMessage
	{
		// Token: 0x06011E10 RID: 73232 RVA: 0x0029D9CA File Offset: 0x0029BBCA
		[NullableContext(1)]
		public static PhantomMusicNotify Create()
		{
			return new PhantomMusicNotify();
		}

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x06011E11 RID: 73233 RVA: 0x0029D9D1 File Offset: 0x0029BBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x06011E12 RID: 73234 RVA: 0x0029D9D4 File Offset: 0x0029BBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicNotify.Descriptor;
			}
		}

		// Token: 0x06011E13 RID: 73235 RVA: 0x0029D9DB File Offset: 0x0029BBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicNotify()
		{
		}

		// Token: 0x06011E14 RID: 73236 RVA: 0x0029D9E3 File Offset: 0x0029BBE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicNotify(PhantomMusicNotify other) : this()
		{
			this.music_ = other.music_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E15 RID: 73237 RVA: 0x0029DA08 File Offset: 0x0029BC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicNotify Clone()
		{
			return new PhantomMusicNotify(this);
		}

		// Token: 0x17003B43 RID: 15171
		// (get) Token: 0x06011E16 RID: 73238 RVA: 0x0029DA10 File Offset: 0x0029BC10
		// (set) Token: 0x06011E17 RID: 73239 RVA: 0x0029DA18 File Offset: 0x0029BC18
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

		// Token: 0x06011E18 RID: 73240 RVA: 0x0029DA21 File Offset: 0x0029BC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicNotify);
		}

		// Token: 0x06011E19 RID: 73241 RVA: 0x0029DA2F File Offset: 0x0029BC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicNotify other)
		{
			return other != null && (other == this || (this.Music == other.Music && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E1A RID: 73242 RVA: 0x0029DA60 File Offset: 0x0029BC60
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

		// Token: 0x06011E1B RID: 73243 RVA: 0x0029DA9F File Offset: 0x0029BC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E1C RID: 73244 RVA: 0x0029DAAC File Offset: 0x0029BCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E1D RID: 73245 RVA: 0x0029DAB5 File Offset: 0x0029BCB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Music != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Music);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E1E RID: 73246 RVA: 0x0029DAE8 File Offset: 0x0029BCE8
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

		// Token: 0x06011E1F RID: 73247 RVA: 0x0029DB26 File Offset: 0x0029BD26
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

		// Token: 0x06011E20 RID: 73248 RVA: 0x0029DB57 File Offset: 0x0029BD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E21 RID: 73249 RVA: 0x0029DB60 File Offset: 0x0029BD60
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Music = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007039 RID: 28729
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400703A RID: 28730
		public const int MusicFieldNumber = 1;

		// Token: 0x0400703B RID: 28731
		private int music_;
	}
}
