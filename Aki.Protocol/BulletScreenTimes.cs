using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000214 RID: 532
	public sealed class BulletScreenTimes : IMessage<BulletScreenTimes>, IMessage, IEquatable<BulletScreenTimes>, IDeepCloneable<BulletScreenTimes>, IBufferMessage
	{
		// Token: 0x06003A69 RID: 14953 RVA: 0x00091807 File Offset: 0x0008FA07
		[NullableContext(1)]
		public static BulletScreenTimes Create()
		{
			return new BulletScreenTimes();
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06003A6A RID: 14954 RVA: 0x0009180E File Offset: 0x0008FA0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BulletScreenTimes> Parser
		{
			get
			{
				return BulletScreenTimes._parser;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06003A6B RID: 14955 RVA: 0x00091815 File Offset: 0x0008FA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06003A6C RID: 14956 RVA: 0x00091818 File Offset: 0x0008FA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BulletScreenTimes.Descriptor;
			}
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x0009181F File Offset: 0x0008FA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletScreenTimes()
		{
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x00091827 File Offset: 0x0008FA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletScreenTimes(BulletScreenTimes other) : this()
		{
			this.bulletScreenId_ = other.bulletScreenId_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x00091858 File Offset: 0x0008FA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletScreenTimes Clone()
		{
			return new BulletScreenTimes(this);
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x00091860 File Offset: 0x0008FA60
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x00091868 File Offset: 0x0008FA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BulletScreenId
		{
			get
			{
				return this.bulletScreenId_;
			}
			set
			{
				this.bulletScreenId_ = value;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x00091871 File Offset: 0x0008FA71
		// (set) Token: 0x06003A73 RID: 14963 RVA: 0x00091879 File Offset: 0x0008FA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x00091882 File Offset: 0x0008FA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BulletScreenTimes);
		}

		// Token: 0x06003A75 RID: 14965 RVA: 0x00091890 File Offset: 0x0008FA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BulletScreenTimes other)
		{
			return other != null && (other == this || (this.BulletScreenId == other.BulletScreenId && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x000918D0 File Offset: 0x0008FAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BulletScreenId != 0)
			{
				num ^= this.BulletScreenId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x00091928 File Offset: 0x0008FB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x00091935 File Offset: 0x0008FB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x00091940 File Offset: 0x0008FB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletScreenId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BulletScreenId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x00091998 File Offset: 0x0008FB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BulletScreenId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BulletScreenId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x000919F0 File Offset: 0x0008FBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BulletScreenTimes other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BulletScreenId != 0)
			{
				this.BulletScreenId = other.BulletScreenId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x00091A40 File Offset: 0x0008FC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x00091A4C File Offset: 0x0008FC4C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.BulletScreenId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002BCE RID: 11214
		private static readonly MessageParser<BulletScreenTimes> _parser = new MessageParser<BulletScreenTimes>(() => new BulletScreenTimes());

		// Token: 0x04002BCF RID: 11215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BD0 RID: 11216
		public const int BulletScreenIdFieldNumber = 1;

		// Token: 0x04002BD1 RID: 11217
		private int bulletScreenId_;

		// Token: 0x04002BD2 RID: 11218
		public const int NumFieldNumber = 2;

		// Token: 0x04002BD3 RID: 11219
		private int num_;
	}
}
