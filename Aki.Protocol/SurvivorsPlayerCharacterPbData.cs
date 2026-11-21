using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134A RID: 4938
	public sealed class SurvivorsPlayerCharacterPbData : IMessage<SurvivorsPlayerCharacterPbData>, IMessage, IEquatable<SurvivorsPlayerCharacterPbData>, IDeepCloneable<SurvivorsPlayerCharacterPbData>, IBufferMessage
	{
		// Token: 0x0601A51D RID: 107805 RVA: 0x003D6670 File Offset: 0x003D4870
		[NullableContext(1)]
		public static SurvivorsPlayerCharacterPbData Create()
		{
			return new SurvivorsPlayerCharacterPbData();
		}

		// Token: 0x17005929 RID: 22825
		// (get) Token: 0x0601A51E RID: 107806 RVA: 0x003D6677 File Offset: 0x003D4877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700592A RID: 22826
		// (get) Token: 0x0601A51F RID: 107807 RVA: 0x003D667A File Offset: 0x003D487A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsPlayerCharacterPbData.Descriptor;
			}
		}

		// Token: 0x0601A520 RID: 107808 RVA: 0x003D6681 File Offset: 0x003D4881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPlayerCharacterPbData()
		{
		}

		// Token: 0x0601A521 RID: 107809 RVA: 0x003D6689 File Offset: 0x003D4889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPlayerCharacterPbData(SurvivorsPlayerCharacterPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A522 RID: 107810 RVA: 0x003D66A2 File Offset: 0x003D48A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPlayerCharacterPbData Clone()
		{
			return new SurvivorsPlayerCharacterPbData(this);
		}

		// Token: 0x0601A523 RID: 107811 RVA: 0x003D66AA File Offset: 0x003D48AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsPlayerCharacterPbData);
		}

		// Token: 0x0601A524 RID: 107812 RVA: 0x003D66B8 File Offset: 0x003D48B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsPlayerCharacterPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A525 RID: 107813 RVA: 0x003D66D8 File Offset: 0x003D48D8
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

		// Token: 0x0601A526 RID: 107814 RVA: 0x003D66FE File Offset: 0x003D48FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A527 RID: 107815 RVA: 0x003D670B File Offset: 0x003D490B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A528 RID: 107816 RVA: 0x003D6714 File Offset: 0x003D4914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A529 RID: 107817 RVA: 0x003D672C File Offset: 0x003D492C
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

		// Token: 0x0601A52A RID: 107818 RVA: 0x003D6752 File Offset: 0x003D4952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsPlayerCharacterPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A52B RID: 107819 RVA: 0x003D676F File Offset: 0x003D496F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A52C RID: 107820 RVA: 0x003D6778 File Offset: 0x003D4978
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

		// Token: 0x04009ABB RID: 39611
		private UnknownFieldSet _unknownFields;
	}
}
