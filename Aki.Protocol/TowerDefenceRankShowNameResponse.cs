using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AC RID: 5036
	[NetMessage(EMessageId.TowerDefenceRankShowNameResponse)]
	public sealed class TowerDefenceRankShowNameResponse : IMessage<TowerDefenceRankShowNameResponse>, IMessage, IEquatable<TowerDefenceRankShowNameResponse>, IDeepCloneable<TowerDefenceRankShowNameResponse>, IBufferMessage
	{
		// Token: 0x0601AB82 RID: 109442 RVA: 0x003E0041 File Offset: 0x003DE241
		[NullableContext(1)]
		public static TowerDefenceRankShowNameResponse Create()
		{
			return new TowerDefenceRankShowNameResponse();
		}

		// Token: 0x17005A1A RID: 23066
		// (get) Token: 0x0601AB83 RID: 109443 RVA: 0x003E0048 File Offset: 0x003DE248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A1B RID: 23067
		// (get) Token: 0x0601AB84 RID: 109444 RVA: 0x003E004B File Offset: 0x003DE24B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRankShowNameResponse.Descriptor;
			}
		}

		// Token: 0x0601AB85 RID: 109445 RVA: 0x003E0052 File Offset: 0x003DE252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameResponse()
		{
		}

		// Token: 0x0601AB86 RID: 109446 RVA: 0x003E005A File Offset: 0x003DE25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameResponse(TowerDefenceRankShowNameResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB87 RID: 109447 RVA: 0x003E007F File Offset: 0x003DE27F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameResponse Clone()
		{
			return new TowerDefenceRankShowNameResponse(this);
		}

		// Token: 0x17005A1C RID: 23068
		// (get) Token: 0x0601AB88 RID: 109448 RVA: 0x003E0087 File Offset: 0x003DE287
		// (set) Token: 0x0601AB89 RID: 109449 RVA: 0x003E008F File Offset: 0x003DE28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0601AB8A RID: 109450 RVA: 0x003E0098 File Offset: 0x003DE298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRankShowNameResponse);
		}

		// Token: 0x0601AB8B RID: 109451 RVA: 0x003E00A6 File Offset: 0x003DE2A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRankShowNameResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB8C RID: 109452 RVA: 0x003E00D4 File Offset: 0x003DE2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AB8D RID: 109453 RVA: 0x003E0119 File Offset: 0x003DE319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB8E RID: 109454 RVA: 0x003E0126 File Offset: 0x003DE326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB8F RID: 109455 RVA: 0x003E012F File Offset: 0x003DE32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB90 RID: 109456 RVA: 0x003E0164 File Offset: 0x003DE364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AB91 RID: 109457 RVA: 0x003E01A2 File Offset: 0x003DE3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRankShowNameResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AB92 RID: 109458 RVA: 0x003E01D3 File Offset: 0x003DE3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB93 RID: 109459 RVA: 0x003E01DC File Offset: 0x003DE3DC
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009B2C RID: 39724
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B2D RID: 39725
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009B2E RID: 39726
		private ErrorCode errorCode_;
	}
}
