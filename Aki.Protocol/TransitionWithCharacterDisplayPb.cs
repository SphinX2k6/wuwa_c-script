using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001471 RID: 5233
	public sealed class TransitionWithCharacterDisplayPb : IMessage<TransitionWithCharacterDisplayPb>, IMessage, IEquatable<TransitionWithCharacterDisplayPb>, IDeepCloneable<TransitionWithCharacterDisplayPb>, IBufferMessage
	{
		// Token: 0x0601BCA2 RID: 113826 RVA: 0x00409ADE File Offset: 0x00407CDE
		[NullableContext(1)]
		public static TransitionWithCharacterDisplayPb Create()
		{
			return new TransitionWithCharacterDisplayPb();
		}

		// Token: 0x17005E11 RID: 24081
		// (get) Token: 0x0601BCA3 RID: 113827 RVA: 0x00409AE5 File Offset: 0x00407CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E12 RID: 24082
		// (get) Token: 0x0601BCA4 RID: 113828 RVA: 0x00409AE8 File Offset: 0x00407CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionWithCharacterDisplayPb.Descriptor;
			}
		}

		// Token: 0x0601BCA5 RID: 113829 RVA: 0x00409AEF File Offset: 0x00407CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCharacterDisplayPb()
		{
		}

		// Token: 0x0601BCA6 RID: 113830 RVA: 0x00409AF7 File Offset: 0x00407CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCharacterDisplayPb(TransitionWithCharacterDisplayPb other) : this()
		{
			this.styleId_ = other.styleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BCA7 RID: 113831 RVA: 0x00409B1C File Offset: 0x00407D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCharacterDisplayPb Clone()
		{
			return new TransitionWithCharacterDisplayPb(this);
		}

		// Token: 0x17005E13 RID: 24083
		// (get) Token: 0x0601BCA8 RID: 113832 RVA: 0x00409B24 File Offset: 0x00407D24
		// (set) Token: 0x0601BCA9 RID: 113833 RVA: 0x00409B2C File Offset: 0x00407D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StyleId
		{
			get
			{
				return this.styleId_;
			}
			set
			{
				this.styleId_ = value;
			}
		}

		// Token: 0x0601BCAA RID: 113834 RVA: 0x00409B35 File Offset: 0x00407D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionWithCharacterDisplayPb);
		}

		// Token: 0x0601BCAB RID: 113835 RVA: 0x00409B43 File Offset: 0x00407D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionWithCharacterDisplayPb other)
		{
			return other != null && (other == this || (this.StyleId == other.StyleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BCAC RID: 113836 RVA: 0x00409B74 File Offset: 0x00407D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StyleId != 0)
			{
				num ^= this.StyleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BCAD RID: 113837 RVA: 0x00409BB3 File Offset: 0x00407DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BCAE RID: 113838 RVA: 0x00409BC0 File Offset: 0x00407DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BCAF RID: 113839 RVA: 0x00409BC9 File Offset: 0x00407DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StyleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StyleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BCB0 RID: 113840 RVA: 0x00409BFC File Offset: 0x00407DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StyleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StyleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BCB1 RID: 113841 RVA: 0x00409C3A File Offset: 0x00407E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransitionWithCharacterDisplayPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StyleId != 0)
			{
				this.StyleId = other.StyleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BCB2 RID: 113842 RVA: 0x00409C6B File Offset: 0x00407E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BCB3 RID: 113843 RVA: 0x00409C74 File Offset: 0x00407E74
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
					this.StyleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A142 RID: 41282
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A143 RID: 41283
		public const int StyleIdFieldNumber = 1;

		// Token: 0x0400A144 RID: 41284
		private int styleId_;
	}
}
