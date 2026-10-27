using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E2 RID: 4322
	[NetMessage(EMessageId.RollBlockOpenGamePlayNotify)]
	public sealed class RollBlockOpenGamePlayNotify : IMessage<RollBlockOpenGamePlayNotify>, IMessage, IEquatable<RollBlockOpenGamePlayNotify>, IDeepCloneable<RollBlockOpenGamePlayNotify>, IBufferMessage
	{
		// Token: 0x060170E1 RID: 94433 RVA: 0x003589A5 File Offset: 0x00356BA5
		[NullableContext(1)]
		public static RollBlockOpenGamePlayNotify Create()
		{
			return new RollBlockOpenGamePlayNotify();
		}

		// Token: 0x17004D3B RID: 19771
		// (get) Token: 0x060170E2 RID: 94434 RVA: 0x003589AC File Offset: 0x00356BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D3C RID: 19772
		// (get) Token: 0x060170E3 RID: 94435 RVA: 0x003589AF File Offset: 0x00356BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockOpenGamePlayNotify.Descriptor;
			}
		}

		// Token: 0x060170E4 RID: 94436 RVA: 0x003589B6 File Offset: 0x00356BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockOpenGamePlayNotify()
		{
		}

		// Token: 0x060170E5 RID: 94437 RVA: 0x003589BE File Offset: 0x00356BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockOpenGamePlayNotify(RollBlockOpenGamePlayNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060170E6 RID: 94438 RVA: 0x003589F3 File Offset: 0x00356BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockOpenGamePlayNotify Clone()
		{
			return new RollBlockOpenGamePlayNotify(this);
		}

		// Token: 0x17004D3D RID: 19773
		// (get) Token: 0x060170E7 RID: 94439 RVA: 0x003589FB File Offset: 0x00356BFB
		// (set) Token: 0x060170E8 RID: 94440 RVA: 0x00358A03 File Offset: 0x00356C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayPbInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x060170E9 RID: 94441 RVA: 0x00358A0C File Offset: 0x00356C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockOpenGamePlayNotify);
		}

		// Token: 0x060170EA RID: 94442 RVA: 0x00358A1A File Offset: 0x00356C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockOpenGamePlayNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060170EB RID: 94443 RVA: 0x00358A50 File Offset: 0x00356C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060170EC RID: 94444 RVA: 0x00358A8C File Offset: 0x00356C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060170ED RID: 94445 RVA: 0x00358A99 File Offset: 0x00356C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060170EE RID: 94446 RVA: 0x00358AA2 File Offset: 0x00356CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060170EF RID: 94447 RVA: 0x00358AD4 File Offset: 0x00356CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060170F0 RID: 94448 RVA: 0x00358B14 File Offset: 0x00356D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockOpenGamePlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new RollBlockGamePlayPbInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060170F1 RID: 94449 RVA: 0x00358B68 File Offset: 0x00356D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060170F2 RID: 94450 RVA: 0x00358B74 File Offset: 0x00356D74
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new RollBlockGamePlayPbInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04008934 RID: 35124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008935 RID: 35125
		public const int InfoFieldNumber = 6;

		// Token: 0x04008936 RID: 35126
		private RollBlockGamePlayPbInfo info_;
	}
}
