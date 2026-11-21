using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000254 RID: 596
	public sealed class ChangeEventData : IMessage<ChangeEventData>, IMessage, IEquatable<ChangeEventData>, IDeepCloneable<ChangeEventData>, IBufferMessage
	{
		// Token: 0x06003FAE RID: 16302 RVA: 0x0009D069 File Offset: 0x0009B269
		[NullableContext(1)]
		public static ChangeEventData Create()
		{
			return new ChangeEventData();
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06003FAF RID: 16303 RVA: 0x0009D070 File Offset: 0x0009B270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChangeEventData> Parser
		{
			get
			{
				return ChangeEventData._parser;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x0009D077 File Offset: 0x0009B277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x0009D07A File Offset: 0x0009B27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEventData.Descriptor;
			}
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x0009D081 File Offset: 0x0009B281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventData()
		{
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x0009D08C File Offset: 0x0009B28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventData(ChangeEventData other) : this()
		{
			this.index_ = other.index_;
			this.rogueResGridData_ = ((other.rogueResGridData_ != null) ? other.rogueResGridData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x0009D0D8 File Offset: 0x0009B2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventData Clone()
		{
			return new ChangeEventData(this);
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06003FB5 RID: 16309 RVA: 0x0009D0E0 File Offset: 0x0009B2E0
		// (set) Token: 0x06003FB6 RID: 16310 RVA: 0x0009D0E8 File Offset: 0x0009B2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06003FB7 RID: 16311 RVA: 0x0009D0F1 File Offset: 0x0009B2F1
		// (set) Token: 0x06003FB8 RID: 16312 RVA: 0x0009D0F9 File Offset: 0x0009B2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridData RogueResGridData
		{
			get
			{
				return this.rogueResGridData_;
			}
			set
			{
				this.rogueResGridData_ = value;
			}
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x0009D102 File Offset: 0x0009B302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEventData);
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x0009D110 File Offset: 0x0009B310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEventData other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this.RogueResGridData, other.RogueResGridData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x0009D160 File Offset: 0x0009B360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.rogueResGridData_ != null)
			{
				num ^= this.RogueResGridData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x0009D1B5 File Offset: 0x0009B3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x0009D1C2 File Offset: 0x0009B3C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x0009D1CC File Offset: 0x0009B3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.rogueResGridData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueResGridData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x0009D224 File Offset: 0x0009B424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.rogueResGridData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResGridData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x0009D27C File Offset: 0x0009B47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeEventData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.rogueResGridData_ != null)
			{
				if (this.rogueResGridData_ == null)
				{
					this.RogueResGridData = new RogueResGridData();
				}
				this.RogueResGridData.MergeFrom(other.RogueResGridData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x0009D2E4 File Offset: 0x0009B4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x0009D2F0 File Offset: 0x0009B4F0
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueResGridData_ == null)
						{
							this.RogueResGridData = new RogueResGridData();
						}
						input.ReadMessage(this.RogueResGridData);
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D88 RID: 11656
		private static readonly MessageParser<ChangeEventData> _parser = new MessageParser<ChangeEventData>(() => new ChangeEventData());

		// Token: 0x04002D89 RID: 11657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D8A RID: 11658
		public const int IndexFieldNumber = 1;

		// Token: 0x04002D8B RID: 11659
		private int index_;

		// Token: 0x04002D8C RID: 11660
		public const int RogueResGridDataFieldNumber = 2;

		// Token: 0x04002D8D RID: 11661
		private RogueResGridData rogueResGridData_;
	}
}
