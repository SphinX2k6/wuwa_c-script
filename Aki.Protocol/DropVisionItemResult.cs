using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FA RID: 1018
	public sealed class DropVisionItemResult : IMessage<DropVisionItemResult>, IMessage, IEquatable<DropVisionItemResult>, IDeepCloneable<DropVisionItemResult>, IBufferMessage
	{
		// Token: 0x060062B0 RID: 25264 RVA: 0x000EDC2C File Offset: 0x000EBE2C
		[NullableContext(1)]
		public static DropVisionItemResult Create()
		{
			return new DropVisionItemResult();
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060062B1 RID: 25265 RVA: 0x000EDC33 File Offset: 0x000EBE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DropVisionItemResult> Parser
		{
			get
			{
				return DropVisionItemResult._parser;
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x060062B2 RID: 25266 RVA: 0x000EDC3A File Offset: 0x000EBE3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x060062B3 RID: 25267 RVA: 0x000EDC3D File Offset: 0x000EBE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropVisionItemResult.Descriptor;
			}
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x000EDC44 File Offset: 0x000EBE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropVisionItemResult()
		{
		}

		// Token: 0x060062B5 RID: 25269 RVA: 0x000EDC4C File Offset: 0x000EBE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropVisionItemResult(DropVisionItemResult other) : this()
		{
			this.playerId_ = other.playerId_;
			this.drop_ = other.drop_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x000EDC7D File Offset: 0x000EBE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropVisionItemResult Clone()
		{
			return new DropVisionItemResult(this);
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060062B7 RID: 25271 RVA: 0x000EDC85 File Offset: 0x000EBE85
		// (set) Token: 0x060062B8 RID: 25272 RVA: 0x000EDC8D File Offset: 0x000EBE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060062B9 RID: 25273 RVA: 0x000EDC96 File Offset: 0x000EBE96
		// (set) Token: 0x060062BA RID: 25274 RVA: 0x000EDC9E File Offset: 0x000EBE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Drop
		{
			get
			{
				return this.drop_;
			}
			set
			{
				this.drop_ = value;
			}
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x000EDCA7 File Offset: 0x000EBEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropVisionItemResult);
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x000EDCB5 File Offset: 0x000EBEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropVisionItemResult other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Drop == other.Drop && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x000EDCF4 File Offset: 0x000EBEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Drop)
			{
				num ^= this.Drop.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x000EDD4C File Offset: 0x000EBF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x000EDD59 File Offset: 0x000EBF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062C0 RID: 25280 RVA: 0x000EDD64 File Offset: 0x000EBF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Drop)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Drop);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x000EDDBC File Offset: 0x000EBFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Drop)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x000EDE08 File Offset: 0x000EC008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropVisionItemResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Drop)
			{
				this.Drop = other.Drop;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x000EDE58 File Offset: 0x000EC058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x000EDE64 File Offset: 0x000EC064
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
						this.Drop = input.ReadBool();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400384A RID: 14410
		private static readonly MessageParser<DropVisionItemResult> _parser = new MessageParser<DropVisionItemResult>(() => new DropVisionItemResult());

		// Token: 0x0400384B RID: 14411
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400384C RID: 14412
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x0400384D RID: 14413
		private int playerId_;

		// Token: 0x0400384E RID: 14414
		public const int DropFieldNumber = 2;

		// Token: 0x0400384F RID: 14415
		private bool drop_;
	}
}
