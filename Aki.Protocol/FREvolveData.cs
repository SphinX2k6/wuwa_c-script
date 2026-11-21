using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000632 RID: 1586
	public sealed class FREvolveData : IMessage<FREvolveData>, IMessage, IEquatable<FREvolveData>, IDeepCloneable<FREvolveData>, IBufferMessage
	{
		// Token: 0x0600927F RID: 37503 RVA: 0x00162D49 File Offset: 0x00160F49
		[NullableContext(1)]
		public static FREvolveData Create()
		{
			return new FREvolveData();
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x06009280 RID: 37504 RVA: 0x00162D50 File Offset: 0x00160F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x06009281 RID: 37505 RVA: 0x00162D53 File Offset: 0x00160F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FREvolveData.Descriptor;
			}
		}

		// Token: 0x06009282 RID: 37506 RVA: 0x00162D5A File Offset: 0x00160F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveData()
		{
		}

		// Token: 0x06009283 RID: 37507 RVA: 0x00162D62 File Offset: 0x00160F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveData(FREvolveData other) : this()
		{
			this.curExp_ = other.curExp_;
			this.curLevel_ = other.curLevel_;
			this.expPerLevel_ = other.expPerLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009284 RID: 37508 RVA: 0x00162D9F File Offset: 0x00160F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveData Clone()
		{
			return new FREvolveData(this);
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06009285 RID: 37509 RVA: 0x00162DA7 File Offset: 0x00160FA7
		// (set) Token: 0x06009286 RID: 37510 RVA: 0x00162DAF File Offset: 0x00160FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurExp
		{
			get
			{
				return this.curExp_;
			}
			set
			{
				this.curExp_ = value;
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x06009287 RID: 37511 RVA: 0x00162DB8 File Offset: 0x00160FB8
		// (set) Token: 0x06009288 RID: 37512 RVA: 0x00162DC0 File Offset: 0x00160FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLevel
		{
			get
			{
				return this.curLevel_;
			}
			set
			{
				this.curLevel_ = value;
			}
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x06009289 RID: 37513 RVA: 0x00162DC9 File Offset: 0x00160FC9
		// (set) Token: 0x0600928A RID: 37514 RVA: 0x00162DD1 File Offset: 0x00160FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExpPerLevel
		{
			get
			{
				return this.expPerLevel_;
			}
			set
			{
				this.expPerLevel_ = value;
			}
		}

		// Token: 0x0600928B RID: 37515 RVA: 0x00162DDA File Offset: 0x00160FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FREvolveData);
		}

		// Token: 0x0600928C RID: 37516 RVA: 0x00162DE8 File Offset: 0x00160FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FREvolveData other)
		{
			return other != null && (other == this || (this.CurExp == other.CurExp && this.CurLevel == other.CurLevel && this.ExpPerLevel == other.ExpPerLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600928D RID: 37517 RVA: 0x00162E44 File Offset: 0x00161044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurExp != 0)
			{
				num ^= this.CurExp.GetHashCode();
			}
			if (this.CurLevel != 0)
			{
				num ^= this.CurLevel.GetHashCode();
			}
			if (this.ExpPerLevel != 0)
			{
				num ^= this.ExpPerLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600928E RID: 37518 RVA: 0x00162EB5 File Offset: 0x001610B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600928F RID: 37519 RVA: 0x00162EC2 File Offset: 0x001610C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009290 RID: 37520 RVA: 0x00162ECC File Offset: 0x001610CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurExp != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurExp);
			}
			if (this.CurLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurLevel);
			}
			if (this.ExpPerLevel != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ExpPerLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009291 RID: 37521 RVA: 0x00162F40 File Offset: 0x00161140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurExp);
			}
			if (this.CurLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLevel);
			}
			if (this.ExpPerLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExpPerLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009292 RID: 37522 RVA: 0x00162FB0 File Offset: 0x001611B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FREvolveData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurExp != 0)
			{
				this.CurExp = other.CurExp;
			}
			if (other.CurLevel != 0)
			{
				this.CurLevel = other.CurLevel;
			}
			if (other.ExpPerLevel != 0)
			{
				this.ExpPerLevel = other.ExpPerLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009293 RID: 37523 RVA: 0x00163014 File Offset: 0x00161214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009294 RID: 37524 RVA: 0x00163020 File Offset: 0x00161220
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
							this.ExpPerLevel = input.ReadInt32();
						}
					}
					else
					{
						this.CurLevel = input.ReadInt32();
					}
				}
				else
				{
					this.CurExp = input.ReadInt32();
				}
			}
		}

		// Token: 0x040046F9 RID: 18169
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046FA RID: 18170
		public const int CurExpFieldNumber = 1;

		// Token: 0x040046FB RID: 18171
		private int curExp_;

		// Token: 0x040046FC RID: 18172
		public const int CurLevelFieldNumber = 2;

		// Token: 0x040046FD RID: 18173
		private int curLevel_;

		// Token: 0x040046FE RID: 18174
		public const int ExpPerLevelFieldNumber = 3;

		// Token: 0x040046FF RID: 18175
		private int expPerLevel_;
	}
}
