using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000249 RID: 585
	public sealed class ChampionExtra : IMessage<ChampionExtra>, IMessage, IEquatable<ChampionExtra>, IDeepCloneable<ChampionExtra>, IBufferMessage
	{
		// Token: 0x06003ED4 RID: 16084 RVA: 0x0009B4C9 File Offset: 0x000996C9
		[NullableContext(1)]
		public static ChampionExtra Create()
		{
			return new ChampionExtra();
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06003ED5 RID: 16085 RVA: 0x0009B4D0 File Offset: 0x000996D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06003ED6 RID: 16086 RVA: 0x0009B4D3 File Offset: 0x000996D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChampionExtra.Descriptor;
			}
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x0009B4DA File Offset: 0x000996DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChampionExtra()
		{
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x0009B4E2 File Offset: 0x000996E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChampionExtra(ChampionExtra other) : this()
		{
			this.firstCount_ = other.firstCount_;
			this.absoluteRule_ = other.absoluteRule_;
			this.destroyer_ = other.destroyer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x0009B51F File Offset: 0x0009971F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChampionExtra Clone()
		{
			return new ChampionExtra(this);
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x0009B527 File Offset: 0x00099727
		// (set) Token: 0x06003EDB RID: 16091 RVA: 0x0009B52F File Offset: 0x0009972F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstCount
		{
			get
			{
				return this.firstCount_;
			}
			set
			{
				this.firstCount_ = value;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x0009B538 File Offset: 0x00099738
		// (set) Token: 0x06003EDD RID: 16093 RVA: 0x0009B540 File Offset: 0x00099740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AbsoluteRule
		{
			get
			{
				return this.absoluteRule_;
			}
			set
			{
				this.absoluteRule_ = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x0009B549 File Offset: 0x00099749
		// (set) Token: 0x06003EDF RID: 16095 RVA: 0x0009B551 File Offset: 0x00099751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Destroyer
		{
			get
			{
				return this.destroyer_;
			}
			set
			{
				this.destroyer_ = value;
			}
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x0009B55A File Offset: 0x0009975A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChampionExtra);
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x0009B568 File Offset: 0x00099768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChampionExtra other)
		{
			return other != null && (other == this || (this.FirstCount == other.FirstCount && this.AbsoluteRule == other.AbsoluteRule && this.Destroyer == other.Destroyer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x0009B5C4 File Offset: 0x000997C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FirstCount != 0)
			{
				num ^= this.FirstCount.GetHashCode();
			}
			if (this.AbsoluteRule)
			{
				num ^= this.AbsoluteRule.GetHashCode();
			}
			if (this.Destroyer)
			{
				num ^= this.Destroyer.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x0009B635 File Offset: 0x00099835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x0009B642 File Offset: 0x00099842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x0009B64C File Offset: 0x0009984C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FirstCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FirstCount);
			}
			if (this.AbsoluteRule)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.AbsoluteRule);
			}
			if (this.Destroyer)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Destroyer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0009B6C0 File Offset: 0x000998C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FirstCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstCount);
			}
			if (this.AbsoluteRule)
			{
				num += 2;
			}
			if (this.Destroyer)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x0009B718 File Offset: 0x00099918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChampionExtra other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FirstCount != 0)
			{
				this.FirstCount = other.FirstCount;
			}
			if (other.AbsoluteRule)
			{
				this.AbsoluteRule = other.AbsoluteRule;
			}
			if (other.Destroyer)
			{
				this.Destroyer = other.Destroyer;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x0009B77C File Offset: 0x0009997C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x0009B788 File Offset: 0x00099988
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Destroyer = input.ReadBool();
						}
					}
					else
					{
						this.AbsoluteRule = input.ReadBool();
					}
				}
				else
				{
					this.FirstCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D52 RID: 11602
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D53 RID: 11603
		public const int FirstCountFieldNumber = 1;

		// Token: 0x04002D54 RID: 11604
		private int firstCount_;

		// Token: 0x04002D55 RID: 11605
		public const int AbsoluteRuleFieldNumber = 2;

		// Token: 0x04002D56 RID: 11606
		private bool absoluteRule_;

		// Token: 0x04002D57 RID: 11607
		public const int DestroyerFieldNumber = 3;

		// Token: 0x04002D58 RID: 11608
		private bool destroyer_;
	}
}
