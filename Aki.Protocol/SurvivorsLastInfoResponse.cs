using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133C RID: 4924
	[NetMessage(EMessageId.SurvivorsLastInfoResponse)]
	public sealed class SurvivorsLastInfoResponse : IMessage<SurvivorsLastInfoResponse>, IMessage, IEquatable<SurvivorsLastInfoResponse>, IDeepCloneable<SurvivorsLastInfoResponse>, IBufferMessage
	{
		// Token: 0x0601A3F5 RID: 107509 RVA: 0x003D3A0E File Offset: 0x003D1C0E
		[NullableContext(1)]
		public static SurvivorsLastInfoResponse Create()
		{
			return new SurvivorsLastInfoResponse();
		}

		// Token: 0x170058E8 RID: 22760
		// (get) Token: 0x0601A3F6 RID: 107510 RVA: 0x003D3A15 File Offset: 0x003D1C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058E9 RID: 22761
		// (get) Token: 0x0601A3F7 RID: 107511 RVA: 0x003D3A18 File Offset: 0x003D1C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsLastInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601A3F8 RID: 107512 RVA: 0x003D3A1F File Offset: 0x003D1C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoResponse()
		{
		}

		// Token: 0x0601A3F9 RID: 107513 RVA: 0x003D3A27 File Offset: 0x003D1C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoResponse(SurvivorsLastInfoResponse other) : this()
		{
			this.survivorLastInfo_ = ((other.survivorLastInfo_ != null) ? other.survivorLastInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A3FA RID: 107514 RVA: 0x003D3A5C File Offset: 0x003D1C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoResponse Clone()
		{
			return new SurvivorsLastInfoResponse(this);
		}

		// Token: 0x170058EA RID: 22762
		// (get) Token: 0x0601A3FB RID: 107515 RVA: 0x003D3A64 File Offset: 0x003D1C64
		// (set) Token: 0x0601A3FC RID: 107516 RVA: 0x003D3A6C File Offset: 0x003D1C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorLastInfo SurvivorLastInfo
		{
			get
			{
				return this.survivorLastInfo_;
			}
			set
			{
				this.survivorLastInfo_ = value;
			}
		}

		// Token: 0x0601A3FD RID: 107517 RVA: 0x003D3A75 File Offset: 0x003D1C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsLastInfoResponse);
		}

		// Token: 0x0601A3FE RID: 107518 RVA: 0x003D3A83 File Offset: 0x003D1C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsLastInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorLastInfo, other.SurvivorLastInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A3FF RID: 107519 RVA: 0x003D3AB8 File Offset: 0x003D1CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.survivorLastInfo_ != null)
			{
				num ^= this.SurvivorLastInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A400 RID: 107520 RVA: 0x003D3AF4 File Offset: 0x003D1CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A401 RID: 107521 RVA: 0x003D3B01 File Offset: 0x003D1D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A402 RID: 107522 RVA: 0x003D3B0A File Offset: 0x003D1D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.survivorLastInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SurvivorLastInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A403 RID: 107523 RVA: 0x003D3B3C File Offset: 0x003D1D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.survivorLastInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorLastInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A404 RID: 107524 RVA: 0x003D3B7C File Offset: 0x003D1D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsLastInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.survivorLastInfo_ != null)
			{
				if (this.survivorLastInfo_ == null)
				{
					this.SurvivorLastInfo = new SurvivorLastInfo();
				}
				this.SurvivorLastInfo.MergeFrom(other.SurvivorLastInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A405 RID: 107525 RVA: 0x003D3BD0 File Offset: 0x003D1DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A406 RID: 107526 RVA: 0x003D3BDC File Offset: 0x003D1DDC
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.survivorLastInfo_ == null)
					{
						this.SurvivorLastInfo = new SurvivorLastInfo();
					}
					input.ReadMessage(this.SurvivorLastInfo);
				}
			}
		}

		// Token: 0x04009A65 RID: 39525
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A66 RID: 39526
		public const int SurvivorLastInfoFieldNumber = 1;

		// Token: 0x04009A67 RID: 39527
		private SurvivorLastInfo survivorLastInfo_;
	}
}
