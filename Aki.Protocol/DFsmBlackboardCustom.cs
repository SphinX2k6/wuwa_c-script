using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C0 RID: 960
	public sealed class DFsmBlackboardCustom : IMessage<DFsmBlackboardCustom>, IMessage, IEquatable<DFsmBlackboardCustom>, IDeepCloneable<DFsmBlackboardCustom>, IBufferMessage
	{
		// Token: 0x06005E41 RID: 24129 RVA: 0x000E4E83 File Offset: 0x000E3083
		[NullableContext(1)]
		public static DFsmBlackboardCustom Create()
		{
			return new DFsmBlackboardCustom();
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06005E42 RID: 24130 RVA: 0x000E4E8A File Offset: 0x000E308A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DFsmBlackboardCustom> Parser
		{
			get
			{
				return DFsmBlackboardCustom._parser;
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06005E43 RID: 24131 RVA: 0x000E4E91 File Offset: 0x000E3091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x06005E44 RID: 24132 RVA: 0x000E4E94 File Offset: 0x000E3094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DFsmBlackboardCustom.Descriptor;
			}
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x000E4E9B File Offset: 0x000E309B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackboardCustom()
		{
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x000E4EAE File Offset: 0x000E30AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackboardCustom(DFsmBlackboardCustom other) : this()
		{
			this.key_ = other.key_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x000E4EDF File Offset: 0x000E30DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsmBlackboardCustom Clone()
		{
			return new DFsmBlackboardCustom(this);
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x06005E48 RID: 24136 RVA: 0x000E4EE7 File Offset: 0x000E30E7
		// (set) Token: 0x06005E49 RID: 24137 RVA: 0x000E4EEF File Offset: 0x000E30EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06005E4A RID: 24138 RVA: 0x000E4F02 File Offset: 0x000E3102
		// (set) Token: 0x06005E4B RID: 24139 RVA: 0x000E4F0A File Offset: 0x000E310A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x000E4F13 File Offset: 0x000E3113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DFsmBlackboardCustom);
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x000E4F24 File Offset: 0x000E3124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DFsmBlackboardCustom other)
		{
			return other != null && (other == this || (!(this.Key != other.Key) && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x000E4F74 File Offset: 0x000E3174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key.Length != 0)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x000E4FCE File Offset: 0x000E31CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x000E4FDB File Offset: 0x000E31DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x000E4FE4 File Offset: 0x000E31E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Key);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x000E5044 File Offset: 0x000E3244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x000E50A0 File Offset: 0x000E32A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DFsmBlackboardCustom other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key.Length != 0)
			{
				this.Key = other.Key;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x000E50F5 File Offset: 0x000E32F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x000E5100 File Offset: 0x000E3300
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadInt32();
					}
				}
				else
				{
					this.Key = input.ReadString();
				}
			}
		}

		// Token: 0x0400372D RID: 14125
		private static readonly MessageParser<DFsmBlackboardCustom> _parser = new MessageParser<DFsmBlackboardCustom>(() => new DFsmBlackboardCustom());

		// Token: 0x0400372E RID: 14126
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400372F RID: 14127
		public const int KeyFieldNumber = 1;

		// Token: 0x04003730 RID: 14128
		private string key_ = "";

		// Token: 0x04003731 RID: 14129
		public const int ValueFieldNumber = 2;

		// Token: 0x04003732 RID: 14130
		private int value_;
	}
}
