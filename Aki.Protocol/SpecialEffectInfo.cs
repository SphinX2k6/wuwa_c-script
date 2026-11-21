using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D4 RID: 4820
	public sealed class SpecialEffectInfo : IMessage<SpecialEffectInfo>, IMessage, IEquatable<SpecialEffectInfo>, IDeepCloneable<SpecialEffectInfo>, IBufferMessage
	{
		// Token: 0x06019BA4 RID: 105380 RVA: 0x003C0FF8 File Offset: 0x003BF1F8
		[NullableContext(1)]
		public static SpecialEffectInfo Create()
		{
			return new SpecialEffectInfo();
		}

		// Token: 0x17005723 RID: 22307
		// (get) Token: 0x06019BA5 RID: 105381 RVA: 0x003C0FFF File Offset: 0x003BF1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005724 RID: 22308
		// (get) Token: 0x06019BA6 RID: 105382 RVA: 0x003C1002 File Offset: 0x003BF202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialEffectInfo.Descriptor;
			}
		}

		// Token: 0x06019BA7 RID: 105383 RVA: 0x003C1009 File Offset: 0x003BF209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialEffectInfo()
		{
		}

		// Token: 0x06019BA8 RID: 105384 RVA: 0x003C1011 File Offset: 0x003BF211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialEffectInfo(SpecialEffectInfo other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019BA9 RID: 105385 RVA: 0x003C102A File Offset: 0x003BF22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialEffectInfo Clone()
		{
			return new SpecialEffectInfo(this);
		}

		// Token: 0x06019BAA RID: 105386 RVA: 0x003C1032 File Offset: 0x003BF232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialEffectInfo);
		}

		// Token: 0x06019BAB RID: 105387 RVA: 0x003C1040 File Offset: 0x003BF240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialEffectInfo other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019BAC RID: 105388 RVA: 0x003C1060 File Offset: 0x003BF260
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

		// Token: 0x06019BAD RID: 105389 RVA: 0x003C1086 File Offset: 0x003BF286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019BAE RID: 105390 RVA: 0x003C1093 File Offset: 0x003BF293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019BAF RID: 105391 RVA: 0x003C109C File Offset: 0x003BF29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019BB0 RID: 105392 RVA: 0x003C10B4 File Offset: 0x003BF2B4
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

		// Token: 0x06019BB1 RID: 105393 RVA: 0x003C10DA File Offset: 0x003BF2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpecialEffectInfo other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019BB2 RID: 105394 RVA: 0x003C10F7 File Offset: 0x003BF2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019BB3 RID: 105395 RVA: 0x003C1100 File Offset: 0x003BF300
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

		// Token: 0x040097F2 RID: 38898
		private UnknownFieldSet _unknownFields;
	}
}
