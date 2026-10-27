using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001248 RID: 4680
	[NetMessage(EMessageId.SlashAndTowerInfoRequest)]
	public sealed class SlashAndTowerInfoRequest : IMessage<SlashAndTowerInfoRequest>, IMessage, IEquatable<SlashAndTowerInfoRequest>, IDeepCloneable<SlashAndTowerInfoRequest>, IBufferMessage
	{
		// Token: 0x06018F07 RID: 102151 RVA: 0x003A111F File Offset: 0x0039F31F
		[NullableContext(1)]
		public static SlashAndTowerInfoRequest Create()
		{
			return new SlashAndTowerInfoRequest();
		}

		// Token: 0x1700541B RID: 21531
		// (get) Token: 0x06018F08 RID: 102152 RVA: 0x003A1126 File Offset: 0x0039F326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700541C RID: 21532
		// (get) Token: 0x06018F09 RID: 102153 RVA: 0x003A1129 File Offset: 0x0039F329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerInfoRequest.Descriptor;
			}
		}

		// Token: 0x06018F0A RID: 102154 RVA: 0x003A1130 File Offset: 0x0039F330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerInfoRequest()
		{
		}

		// Token: 0x06018F0B RID: 102155 RVA: 0x003A1138 File Offset: 0x0039F338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerInfoRequest(SlashAndTowerInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F0C RID: 102156 RVA: 0x003A1151 File Offset: 0x0039F351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerInfoRequest Clone()
		{
			return new SlashAndTowerInfoRequest(this);
		}

		// Token: 0x06018F0D RID: 102157 RVA: 0x003A1159 File Offset: 0x0039F359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerInfoRequest);
		}

		// Token: 0x06018F0E RID: 102158 RVA: 0x003A1167 File Offset: 0x0039F367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06018F0F RID: 102159 RVA: 0x003A1188 File Offset: 0x0039F388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018F10 RID: 102160 RVA: 0x003A11AE File Offset: 0x0039F3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F11 RID: 102161 RVA: 0x003A11BB File Offset: 0x0039F3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F12 RID: 102162 RVA: 0x003A11C4 File Offset: 0x0039F3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F13 RID: 102163 RVA: 0x003A11DC File Offset: 0x0039F3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F14 RID: 102164 RVA: 0x003A1202 File Offset: 0x0039F402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F15 RID: 102165 RVA: 0x003A121F File Offset: 0x0039F41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F16 RID: 102166 RVA: 0x003A1228 File Offset: 0x0039F428
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400930D RID: 37645
		private UnknownFieldSet _unknownFields;
	}
}
