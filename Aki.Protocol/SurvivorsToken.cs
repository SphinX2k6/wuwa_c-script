using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012EE RID: 4846
	public sealed class SurvivorsToken : IMessage<SurvivorsToken>, IMessage, IEquatable<SurvivorsToken>, IDeepCloneable<SurvivorsToken>, IBufferMessage
	{
		// Token: 0x06019C4E RID: 105550 RVA: 0x003BED08 File Offset: 0x003BCF08
		[NullableContext(1)]
		public static SurvivorsToken Create()
		{
			return new SurvivorsToken();
		}

		// Token: 0x170056EA RID: 22250
		// (get) Token: 0x06019C4F RID: 105551 RVA: 0x003BED0F File Offset: 0x003BCF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056EB RID: 22251
		// (get) Token: 0x06019C50 RID: 105552 RVA: 0x003BED12 File Offset: 0x003BCF12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsToken.Descriptor;
			}
		}

		// Token: 0x06019C51 RID: 105553 RVA: 0x003BED19 File Offset: 0x003BCF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsToken()
		{
		}

		// Token: 0x06019C52 RID: 105554 RVA: 0x003BED21 File Offset: 0x003BCF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsToken(SurvivorsToken other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C53 RID: 105555 RVA: 0x003BED3A File Offset: 0x003BCF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsToken Clone()
		{
			return new SurvivorsToken(this);
		}

		// Token: 0x06019C54 RID: 105556 RVA: 0x003BED42 File Offset: 0x003BCF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsToken);
		}

		// Token: 0x06019C55 RID: 105557 RVA: 0x003BED50 File Offset: 0x003BCF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsToken other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019C56 RID: 105558 RVA: 0x003BED70 File Offset: 0x003BCF70
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

		// Token: 0x06019C57 RID: 105559 RVA: 0x003BED96 File Offset: 0x003BCF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C58 RID: 105560 RVA: 0x003BEDA3 File Offset: 0x003BCFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C59 RID: 105561 RVA: 0x003BEDAC File Offset: 0x003BCFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C5A RID: 105562 RVA: 0x003BEDC4 File Offset: 0x003BCFC4
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

		// Token: 0x06019C5B RID: 105563 RVA: 0x003BEDEA File Offset: 0x003BCFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsToken other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019C5C RID: 105564 RVA: 0x003BEE07 File Offset: 0x003BD007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C5D RID: 105565 RVA: 0x003BEE10 File Offset: 0x003BD010
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

		// Token: 0x040096D7 RID: 38615
		private UnknownFieldSet _unknownFields;
	}
}
