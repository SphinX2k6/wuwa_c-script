using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000411 RID: 1041
	public sealed class DropVisionItemResult : IMessage<DropVisionItemResult>, IMessage, IEquatable<DropVisionItemResult>, IDeepCloneable<DropVisionItemResult>, IBufferMessage
	{
		// Token: 0x06006440 RID: 25664 RVA: 0x000F0DA4 File Offset: 0x000EEFA4
		[NullableContext(1)]
		public static DropVisionItemResult Create()
		{
			return new DropVisionItemResult();
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06006441 RID: 25665 RVA: 0x000F0DAB File Offset: 0x000EEFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DropVisionItemResult> Parser
		{
			get
			{
				return DropVisionItemResult._parser;
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06006442 RID: 25666 RVA: 0x000F0DB2 File Offset: 0x000EEFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06006443 RID: 25667 RVA: 0x000F0DB5 File Offset: 0x000EEFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropVisionItemResult.Descriptor;
			}
		}

		// Token: 0x06006444 RID: 25668 RVA: 0x000F0DBC File Offset: 0x000EEFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropVisionItemResult()
		{
		}

		// Token: 0x06006445 RID: 25669 RVA: 0x000F0DC4 File Offset: 0x000EEFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropVisionItemResult(DropVisionItemResult other) : this()
		{
			this.playerId_ = other.playerId_;
			this.drop_ = other.drop_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006446 RID: 25670 RVA: 0x000F0DF5 File Offset: 0x000EEFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropVisionItemResult Clone()
		{
			return new DropVisionItemResult(this);
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06006447 RID: 25671 RVA: 0x000F0DFD File Offset: 0x000EEFFD
		// (set) Token: 0x06006448 RID: 25672 RVA: 0x000F0E05 File Offset: 0x000EF005
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

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06006449 RID: 25673 RVA: 0x000F0E0E File Offset: 0x000EF00E
		// (set) Token: 0x0600644A RID: 25674 RVA: 0x000F0E16 File Offset: 0x000EF016
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

		// Token: 0x0600644B RID: 25675 RVA: 0x000F0E1F File Offset: 0x000EF01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropVisionItemResult);
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x000F0E2D File Offset: 0x000EF02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropVisionItemResult other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Drop == other.Drop && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600644D RID: 25677 RVA: 0x000F0E6C File Offset: 0x000EF06C
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

		// Token: 0x0600644E RID: 25678 RVA: 0x000F0EC4 File Offset: 0x000EF0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600644F RID: 25679 RVA: 0x000F0ED1 File Offset: 0x000EF0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006450 RID: 25680 RVA: 0x000F0EDC File Offset: 0x000EF0DC
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

		// Token: 0x06006451 RID: 25681 RVA: 0x000F0F34 File Offset: 0x000EF134
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

		// Token: 0x06006452 RID: 25682 RVA: 0x000F0F80 File Offset: 0x000EF180
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

		// Token: 0x06006453 RID: 25683 RVA: 0x000F0FD0 File Offset: 0x000EF1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x000F0FDC File Offset: 0x000EF1DC
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

		// Token: 0x0400385D RID: 14429
		private static readonly MessageParser<DropVisionItemResult> _parser = new MessageParser<DropVisionItemResult>(() => new DropVisionItemResult());

		// Token: 0x0400385E RID: 14430
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400385F RID: 14431
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04003860 RID: 14432
		private int playerId_;

		// Token: 0x04003861 RID: 14433
		public const int DropFieldNumber = 2;

		// Token: 0x04003862 RID: 14434
		private bool drop_;
	}
}
