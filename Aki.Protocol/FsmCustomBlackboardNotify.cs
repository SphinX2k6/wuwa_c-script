using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000657 RID: 1623
	[NetMessage(EMessageId.FsmCustomBlackboardNotify)]
	public sealed class FsmCustomBlackboardNotify : IMessage<FsmCustomBlackboardNotify>, IMessage, IEquatable<FsmCustomBlackboardNotify>, IDeepCloneable<FsmCustomBlackboardNotify>, IBufferMessage
	{
		// Token: 0x06009561 RID: 38241 RVA: 0x00168E29 File Offset: 0x00167029
		[NullableContext(1)]
		public static FsmCustomBlackboardNotify Create()
		{
			return new FsmCustomBlackboardNotify();
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06009562 RID: 38242 RVA: 0x00168E30 File Offset: 0x00167030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x06009563 RID: 38243 RVA: 0x00168E33 File Offset: 0x00167033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmCustomBlackboardNotify.Descriptor;
			}
		}

		// Token: 0x06009564 RID: 38244 RVA: 0x00168E3A File Offset: 0x0016703A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardNotify()
		{
		}

		// Token: 0x06009565 RID: 38245 RVA: 0x00168E42 File Offset: 0x00167042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardNotify(FsmCustomBlackboardNotify other) : this()
		{
			this.fsmCustomBlackboardDatas_ = ((other.fsmCustomBlackboardDatas_ != null) ? other.fsmCustomBlackboardDatas_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009566 RID: 38246 RVA: 0x00168E77 File Offset: 0x00167077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardNotify Clone()
		{
			return new FsmCustomBlackboardNotify(this);
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06009567 RID: 38247 RVA: 0x00168E7F File Offset: 0x0016707F
		// (set) Token: 0x06009568 RID: 38248 RVA: 0x00168E87 File Offset: 0x00167087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardDatas FsmCustomBlackboardDatas
		{
			get
			{
				return this.fsmCustomBlackboardDatas_;
			}
			set
			{
				this.fsmCustomBlackboardDatas_ = value;
			}
		}

		// Token: 0x06009569 RID: 38249 RVA: 0x00168E90 File Offset: 0x00167090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmCustomBlackboardNotify);
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x00168E9E File Offset: 0x0016709E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmCustomBlackboardNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FsmCustomBlackboardDatas, other.FsmCustomBlackboardDatas) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x00168ED4 File Offset: 0x001670D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fsmCustomBlackboardDatas_ != null)
			{
				num ^= this.FsmCustomBlackboardDatas.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x00168F10 File Offset: 0x00167110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600956D RID: 38253 RVA: 0x00168F1D File Offset: 0x0016711D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600956E RID: 38254 RVA: 0x00168F26 File Offset: 0x00167126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fsmCustomBlackboardDatas_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.FsmCustomBlackboardDatas);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600956F RID: 38255 RVA: 0x00168F58 File Offset: 0x00167158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fsmCustomBlackboardDatas_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FsmCustomBlackboardDatas);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009570 RID: 38256 RVA: 0x00168F98 File Offset: 0x00167198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmCustomBlackboardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fsmCustomBlackboardDatas_ != null)
			{
				if (this.fsmCustomBlackboardDatas_ == null)
				{
					this.FsmCustomBlackboardDatas = new FsmCustomBlackboardDatas();
				}
				this.FsmCustomBlackboardDatas.MergeFrom(other.FsmCustomBlackboardDatas);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009571 RID: 38257 RVA: 0x00168FEC File Offset: 0x001671EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009572 RID: 38258 RVA: 0x00168FF8 File Offset: 0x001671F8
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
					if (this.fsmCustomBlackboardDatas_ == null)
					{
						this.FsmCustomBlackboardDatas = new FsmCustomBlackboardDatas();
					}
					input.ReadMessage(this.FsmCustomBlackboardDatas);
				}
			}
		}

		// Token: 0x040047BF RID: 18367
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047C0 RID: 18368
		public const int FsmCustomBlackboardDatasFieldNumber = 6;

		// Token: 0x040047C1 RID: 18369
		private FsmCustomBlackboardDatas fsmCustomBlackboardDatas_;
	}
}
