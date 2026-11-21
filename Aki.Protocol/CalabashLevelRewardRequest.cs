using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000223 RID: 547
	[NetMessage(EMessageId.CalabashLevelRewardRequest)]
	public sealed class CalabashLevelRewardRequest : IMessage<CalabashLevelRewardRequest>, IMessage, IEquatable<CalabashLevelRewardRequest>, IDeepCloneable<CalabashLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x06003BEF RID: 15343 RVA: 0x0009564F File Offset: 0x0009384F
		[NullableContext(1)]
		public static CalabashLevelRewardRequest Create()
		{
			return new CalabashLevelRewardRequest();
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x00095656 File Offset: 0x00093856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x00095659 File Offset: 0x00093859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x00095660 File Offset: 0x00093860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardRequest()
		{
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x00095668 File Offset: 0x00093868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardRequest(CalabashLevelRewardRequest other) : this()
		{
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x0009568D File Offset: 0x0009388D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardRequest Clone()
		{
			return new CalabashLevelRewardRequest(this);
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x00095695 File Offset: 0x00093895
		// (set) Token: 0x06003BF6 RID: 15350 RVA: 0x0009569D File Offset: 0x0009389D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x000956A6 File Offset: 0x000938A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashLevelRewardRequest);
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x000956B4 File Offset: 0x000938B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashLevelRewardRequest other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x000956E4 File Offset: 0x000938E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x00095723 File Offset: 0x00093923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x00095730 File Offset: 0x00093930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x00095739 File Offset: 0x00093939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x0009576C File Offset: 0x0009396C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x000957AA File Offset: 0x000939AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x000957DB File Offset: 0x000939DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x000957E4 File Offset: 0x000939E4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002CA1 RID: 11425
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CA2 RID: 11426
		public const int LevelFieldNumber = 13;

		// Token: 0x04002CA3 RID: 11427
		private int level_;
	}
}
