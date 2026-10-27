using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAE RID: 4014
	[NetMessage(EMessageId.RoguelikeResultNotify)]
	public sealed class RoguelikeResultNotify : IMessage<RoguelikeResultNotify>, IMessage, IEquatable<RoguelikeResultNotify>, IDeepCloneable<RoguelikeResultNotify>, IBufferMessage
	{
		// Token: 0x0601577B RID: 87931 RVA: 0x0031DEDA File Offset: 0x0031C0DA
		[NullableContext(1)]
		public static RoguelikeResultNotify Create()
		{
			return new RoguelikeResultNotify();
		}

		// Token: 0x17004796 RID: 18326
		// (get) Token: 0x0601577C RID: 87932 RVA: 0x0031DEE1 File Offset: 0x0031C0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004797 RID: 18327
		// (get) Token: 0x0601577D RID: 87933 RVA: 0x0031DEE4 File Offset: 0x0031C0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeResultNotify.Descriptor;
			}
		}

		// Token: 0x0601577E RID: 87934 RVA: 0x0031DEEB File Offset: 0x0031C0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultNotify()
		{
		}

		// Token: 0x0601577F RID: 87935 RVA: 0x0031DEF3 File Offset: 0x0031C0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultNotify(RoguelikeResultNotify other) : this()
		{
			this.roguelikeResultInfo_ = ((other.roguelikeResultInfo_ != null) ? other.roguelikeResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015780 RID: 87936 RVA: 0x0031DF28 File Offset: 0x0031C128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultNotify Clone()
		{
			return new RoguelikeResultNotify(this);
		}

		// Token: 0x17004798 RID: 18328
		// (get) Token: 0x06015781 RID: 87937 RVA: 0x0031DF30 File Offset: 0x0031C130
		// (set) Token: 0x06015782 RID: 87938 RVA: 0x0031DF38 File Offset: 0x0031C138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultInfo RoguelikeResultInfo
		{
			get
			{
				return this.roguelikeResultInfo_;
			}
			set
			{
				this.roguelikeResultInfo_ = value;
			}
		}

		// Token: 0x06015783 RID: 87939 RVA: 0x0031DF41 File Offset: 0x0031C141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeResultNotify);
		}

		// Token: 0x06015784 RID: 87940 RVA: 0x0031DF4F File Offset: 0x0031C14F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeResultNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RoguelikeResultInfo, other.RoguelikeResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015785 RID: 87941 RVA: 0x0031DF84 File Offset: 0x0031C184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roguelikeResultInfo_ != null)
			{
				num ^= this.RoguelikeResultInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015786 RID: 87942 RVA: 0x0031DFC0 File Offset: 0x0031C1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015787 RID: 87943 RVA: 0x0031DFCD File Offset: 0x0031C1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015788 RID: 87944 RVA: 0x0031DFD6 File Offset: 0x0031C1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roguelikeResultInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RoguelikeResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015789 RID: 87945 RVA: 0x0031E008 File Offset: 0x0031C208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roguelikeResultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoguelikeResultInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601578A RID: 87946 RVA: 0x0031E048 File Offset: 0x0031C248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roguelikeResultInfo_ != null)
			{
				if (this.roguelikeResultInfo_ == null)
				{
					this.RoguelikeResultInfo = new RoguelikeResultInfo();
				}
				this.RoguelikeResultInfo.MergeFrom(other.RoguelikeResultInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601578B RID: 87947 RVA: 0x0031E09C File Offset: 0x0031C29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601578C RID: 87948 RVA: 0x0031E0A8 File Offset: 0x0031C2A8
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.roguelikeResultInfo_ == null)
					{
						this.RoguelikeResultInfo = new RoguelikeResultInfo();
					}
					input.ReadMessage(this.RoguelikeResultInfo);
				}
			}
		}

		// Token: 0x04008121 RID: 33057
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008122 RID: 33058
		public const int RoguelikeResultInfoFieldNumber = 7;

		// Token: 0x04008123 RID: 33059
		private RoguelikeResultInfo roguelikeResultInfo_;
	}
}
