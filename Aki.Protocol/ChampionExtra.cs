using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000244 RID: 580
	public sealed class ChampionExtra : IMessage<ChampionExtra>, IMessage, IEquatable<ChampionExtra>, IDeepCloneable<ChampionExtra>, IBufferMessage
	{
		// Token: 0x06003E2F RID: 15919 RVA: 0x000998AD File Offset: 0x00097AAD
		[NullableContext(1)]
		public static ChampionExtra Create()
		{
			return new ChampionExtra();
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06003E30 RID: 15920 RVA: 0x000998B4 File Offset: 0x00097AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06003E31 RID: 15921 RVA: 0x000998B7 File Offset: 0x00097AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChampionExtra.Descriptor;
			}
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x000998BE File Offset: 0x00097ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChampionExtra()
		{
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x000998C6 File Offset: 0x00097AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChampionExtra(ChampionExtra other) : this()
		{
			this.firstCount_ = other.firstCount_;
			this.absoluteRule_ = other.absoluteRule_;
			this.destroyer_ = other.destroyer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00099903 File Offset: 0x00097B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChampionExtra Clone()
		{
			return new ChampionExtra(this);
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06003E35 RID: 15925 RVA: 0x0009990B File Offset: 0x00097B0B
		// (set) Token: 0x06003E36 RID: 15926 RVA: 0x00099913 File Offset: 0x00097B13
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

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06003E37 RID: 15927 RVA: 0x0009991C File Offset: 0x00097B1C
		// (set) Token: 0x06003E38 RID: 15928 RVA: 0x00099924 File Offset: 0x00097B24
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

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06003E39 RID: 15929 RVA: 0x0009992D File Offset: 0x00097B2D
		// (set) Token: 0x06003E3A RID: 15930 RVA: 0x00099935 File Offset: 0x00097B35
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

		// Token: 0x06003E3B RID: 15931 RVA: 0x0009993E File Offset: 0x00097B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChampionExtra);
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x0009994C File Offset: 0x00097B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChampionExtra other)
		{
			return other != null && (other == this || (this.FirstCount == other.FirstCount && this.AbsoluteRule == other.AbsoluteRule && this.Destroyer == other.Destroyer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x000999A8 File Offset: 0x00097BA8
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

		// Token: 0x06003E3E RID: 15934 RVA: 0x00099A19 File Offset: 0x00097C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x00099A26 File Offset: 0x00097C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x00099A30 File Offset: 0x00097C30
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

		// Token: 0x06003E41 RID: 15937 RVA: 0x00099AA4 File Offset: 0x00097CA4
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

		// Token: 0x06003E42 RID: 15938 RVA: 0x00099AFC File Offset: 0x00097CFC
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

		// Token: 0x06003E43 RID: 15939 RVA: 0x00099B60 File Offset: 0x00097D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x00099B6C File Offset: 0x00097D6C
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

		// Token: 0x04002CD0 RID: 11472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CD1 RID: 11473
		public const int FirstCountFieldNumber = 1;

		// Token: 0x04002CD2 RID: 11474
		private int firstCount_;

		// Token: 0x04002CD3 RID: 11475
		public const int AbsoluteRuleFieldNumber = 2;

		// Token: 0x04002CD4 RID: 11476
		private bool absoluteRule_;

		// Token: 0x04002CD5 RID: 11477
		public const int DestroyerFieldNumber = 3;

		// Token: 0x04002CD6 RID: 11478
		private bool destroyer_;
	}
}
