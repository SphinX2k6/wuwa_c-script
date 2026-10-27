using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FE RID: 5118
	public sealed class TransitionWithCharacterDisplayPb : IMessage<TransitionWithCharacterDisplayPb>, IMessage, IEquatable<TransitionWithCharacterDisplayPb>, IDeepCloneable<TransitionWithCharacterDisplayPb>, IBufferMessage
	{
		// Token: 0x0601B217 RID: 111127 RVA: 0x003EE80A File Offset: 0x003ECA0A
		[NullableContext(1)]
		public static TransitionWithCharacterDisplayPb Create()
		{
			return new TransitionWithCharacterDisplayPb();
		}

		// Token: 0x17005B7C RID: 23420
		// (get) Token: 0x0601B218 RID: 111128 RVA: 0x003EE811 File Offset: 0x003ECA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B7D RID: 23421
		// (get) Token: 0x0601B219 RID: 111129 RVA: 0x003EE814 File Offset: 0x003ECA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionWithCharacterDisplayPb.Descriptor;
			}
		}

		// Token: 0x0601B21A RID: 111130 RVA: 0x003EE81B File Offset: 0x003ECA1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCharacterDisplayPb()
		{
		}

		// Token: 0x0601B21B RID: 111131 RVA: 0x003EE823 File Offset: 0x003ECA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCharacterDisplayPb(TransitionWithCharacterDisplayPb other) : this()
		{
			this.styleId_ = other.styleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B21C RID: 111132 RVA: 0x003EE848 File Offset: 0x003ECA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCharacterDisplayPb Clone()
		{
			return new TransitionWithCharacterDisplayPb(this);
		}

		// Token: 0x17005B7E RID: 23422
		// (get) Token: 0x0601B21D RID: 111133 RVA: 0x003EE850 File Offset: 0x003ECA50
		// (set) Token: 0x0601B21E RID: 111134 RVA: 0x003EE858 File Offset: 0x003ECA58
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

		// Token: 0x0601B21F RID: 111135 RVA: 0x003EE861 File Offset: 0x003ECA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionWithCharacterDisplayPb);
		}

		// Token: 0x0601B220 RID: 111136 RVA: 0x003EE86F File Offset: 0x003ECA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionWithCharacterDisplayPb other)
		{
			return other != null && (other == this || (this.StyleId == other.StyleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B221 RID: 111137 RVA: 0x003EE8A0 File Offset: 0x003ECAA0
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

		// Token: 0x0601B222 RID: 111138 RVA: 0x003EE8DF File Offset: 0x003ECADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B223 RID: 111139 RVA: 0x003EE8EC File Offset: 0x003ECAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B224 RID: 111140 RVA: 0x003EE8F5 File Offset: 0x003ECAF5
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

		// Token: 0x0601B225 RID: 111141 RVA: 0x003EE928 File Offset: 0x003ECB28
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

		// Token: 0x0601B226 RID: 111142 RVA: 0x003EE966 File Offset: 0x003ECB66
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

		// Token: 0x0601B227 RID: 111143 RVA: 0x003EE997 File Offset: 0x003ECB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B228 RID: 111144 RVA: 0x003EE9A0 File Offset: 0x003ECBA0
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

		// Token: 0x04009CFB RID: 40187
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CFC RID: 40188
		public const int StyleIdFieldNumber = 1;

		// Token: 0x04009CFD RID: 40189
		private int styleId_;
	}
}
