using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FB RID: 4347
	public sealed class RoleTowerTokenCount : IMessage<RoleTowerTokenCount>, IMessage, IEquatable<RoleTowerTokenCount>, IDeepCloneable<RoleTowerTokenCount>, IBufferMessage
	{
		// Token: 0x060173D4 RID: 95188 RVA: 0x00361ED7 File Offset: 0x003600D7
		[NullableContext(1)]
		public static RoleTowerTokenCount Create()
		{
			return new RoleTowerTokenCount();
		}

		// Token: 0x17004E13 RID: 19987
		// (get) Token: 0x060173D5 RID: 95189 RVA: 0x00361EDE File Offset: 0x003600DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerTokenCount> Parser
		{
			get
			{
				return RoleTowerTokenCount._parser;
			}
		}

		// Token: 0x17004E14 RID: 19988
		// (get) Token: 0x060173D6 RID: 95190 RVA: 0x00361EE5 File Offset: 0x003600E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E15 RID: 19989
		// (get) Token: 0x060173D7 RID: 95191 RVA: 0x00361EE8 File Offset: 0x003600E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerTokenCount.Descriptor;
			}
		}

		// Token: 0x060173D8 RID: 95192 RVA: 0x00361EEF File Offset: 0x003600EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenCount()
		{
		}

		// Token: 0x060173D9 RID: 95193 RVA: 0x00361EF7 File Offset: 0x003600F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenCount(RoleTowerTokenCount other) : this()
		{
			this.tokenId_ = other.tokenId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060173DA RID: 95194 RVA: 0x00361F28 File Offset: 0x00360128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenCount Clone()
		{
			return new RoleTowerTokenCount(this);
		}

		// Token: 0x17004E16 RID: 19990
		// (get) Token: 0x060173DB RID: 95195 RVA: 0x00361F30 File Offset: 0x00360130
		// (set) Token: 0x060173DC RID: 95196 RVA: 0x00361F38 File Offset: 0x00360138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TokenId
		{
			get
			{
				return this.tokenId_;
			}
			set
			{
				this.tokenId_ = value;
			}
		}

		// Token: 0x17004E17 RID: 19991
		// (get) Token: 0x060173DD RID: 95197 RVA: 0x00361F41 File Offset: 0x00360141
		// (set) Token: 0x060173DE RID: 95198 RVA: 0x00361F49 File Offset: 0x00360149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x060173DF RID: 95199 RVA: 0x00361F52 File Offset: 0x00360152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerTokenCount);
		}

		// Token: 0x060173E0 RID: 95200 RVA: 0x00361F60 File Offset: 0x00360160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerTokenCount other)
		{
			return other != null && (other == this || (this.TokenId == other.TokenId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060173E1 RID: 95201 RVA: 0x00361FA0 File Offset: 0x003601A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TokenId != 0)
			{
				num ^= this.TokenId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060173E2 RID: 95202 RVA: 0x00361FF8 File Offset: 0x003601F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060173E3 RID: 95203 RVA: 0x00362005 File Offset: 0x00360205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060173E4 RID: 95204 RVA: 0x00362010 File Offset: 0x00360210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TokenId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TokenId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060173E5 RID: 95205 RVA: 0x00362068 File Offset: 0x00360268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TokenId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TokenId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060173E6 RID: 95206 RVA: 0x003620C0 File Offset: 0x003602C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerTokenCount other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TokenId != 0)
			{
				this.TokenId = other.TokenId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060173E7 RID: 95207 RVA: 0x00362110 File Offset: 0x00360310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060173E8 RID: 95208 RVA: 0x0036211C File Offset: 0x0036031C
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.TokenId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008AFD RID: 35581
		private static readonly MessageParser<RoleTowerTokenCount> _parser = new MessageParser<RoleTowerTokenCount>(() => new RoleTowerTokenCount());

		// Token: 0x04008AFE RID: 35582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AFF RID: 35583
		public const int TokenIdFieldNumber = 1;

		// Token: 0x04008B00 RID: 35584
		private int tokenId_;

		// Token: 0x04008B01 RID: 35585
		public const int CountFieldNumber = 2;

		// Token: 0x04008B02 RID: 35586
		private int count_;
	}
}
