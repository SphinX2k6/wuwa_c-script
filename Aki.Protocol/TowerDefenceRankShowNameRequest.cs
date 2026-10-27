using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AB RID: 5035
	[NetMessage(EMessageId.TowerDefenceRankShowNameRequest)]
	public sealed class TowerDefenceRankShowNameRequest : IMessage<TowerDefenceRankShowNameRequest>, IMessage, IEquatable<TowerDefenceRankShowNameRequest>, IDeepCloneable<TowerDefenceRankShowNameRequest>, IBufferMessage
	{
		// Token: 0x0601AB70 RID: 109424 RVA: 0x003DFE73 File Offset: 0x003DE073
		[NullableContext(1)]
		public static TowerDefenceRankShowNameRequest Create()
		{
			return new TowerDefenceRankShowNameRequest();
		}

		// Token: 0x17005A17 RID: 23063
		// (get) Token: 0x0601AB71 RID: 109425 RVA: 0x003DFE7A File Offset: 0x003DE07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A18 RID: 23064
		// (get) Token: 0x0601AB72 RID: 109426 RVA: 0x003DFE7D File Offset: 0x003DE07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRankShowNameRequest.Descriptor;
			}
		}

		// Token: 0x0601AB73 RID: 109427 RVA: 0x003DFE84 File Offset: 0x003DE084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameRequest()
		{
		}

		// Token: 0x0601AB74 RID: 109428 RVA: 0x003DFE8C File Offset: 0x003DE08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameRequest(TowerDefenceRankShowNameRequest other) : this()
		{
			this.showName_ = other.showName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB75 RID: 109429 RVA: 0x003DFEB1 File Offset: 0x003DE0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameRequest Clone()
		{
			return new TowerDefenceRankShowNameRequest(this);
		}

		// Token: 0x17005A19 RID: 23065
		// (get) Token: 0x0601AB76 RID: 109430 RVA: 0x003DFEB9 File Offset: 0x003DE0B9
		// (set) Token: 0x0601AB77 RID: 109431 RVA: 0x003DFEC1 File Offset: 0x003DE0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowName
		{
			get
			{
				return this.showName_;
			}
			set
			{
				this.showName_ = value;
			}
		}

		// Token: 0x0601AB78 RID: 109432 RVA: 0x003DFECA File Offset: 0x003DE0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRankShowNameRequest);
		}

		// Token: 0x0601AB79 RID: 109433 RVA: 0x003DFED8 File Offset: 0x003DE0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRankShowNameRequest other)
		{
			return other != null && (other == this || (this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB7A RID: 109434 RVA: 0x003DFF08 File Offset: 0x003DE108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShowName)
			{
				num ^= this.ShowName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AB7B RID: 109435 RVA: 0x003DFF47 File Offset: 0x003DE147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB7C RID: 109436 RVA: 0x003DFF54 File Offset: 0x003DE154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB7D RID: 109437 RVA: 0x003DFF5D File Offset: 0x003DE15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowName)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ShowName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB7E RID: 109438 RVA: 0x003DFF90 File Offset: 0x003DE190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShowName)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AB7F RID: 109439 RVA: 0x003DFFC2 File Offset: 0x003DE1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRankShowNameRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShowName)
			{
				this.ShowName = other.ShowName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AB80 RID: 109440 RVA: 0x003DFFF3 File Offset: 0x003DE1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB81 RID: 109441 RVA: 0x003DFFFC File Offset: 0x003DE1FC
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ShowName = input.ReadBool();
				}
			}
		}

		// Token: 0x04009B29 RID: 39721
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B2A RID: 39722
		public const int ShowNameFieldNumber = 2;

		// Token: 0x04009B2B RID: 39723
		private bool showName_;
	}
}
