using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016B5 RID: 5813
	[NetMessage(EMessageId.AiInformationPush)]
	public sealed class AiInformationPush : IMessage<AiInformationPush>, IMessage, IEquatable<AiInformationPush>, IDeepCloneable<AiInformationPush>, IBufferMessage
	{
		// Token: 0x0601D1F7 RID: 119287 RVA: 0x00442B35 File Offset: 0x00440D35
		[NullableContext(1)]
		public static AiInformationPush Create()
		{
			return new AiInformationPush();
		}

		// Token: 0x170062CB RID: 25291
		// (get) Token: 0x0601D1F8 RID: 119288 RVA: 0x00442B3C File Offset: 0x00440D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062CC RID: 25292
		// (get) Token: 0x0601D1F9 RID: 119289 RVA: 0x00442B3F File Offset: 0x00440D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiInformationPush.Descriptor;
			}
		}

		// Token: 0x0601D1FA RID: 119290 RVA: 0x00442B46 File Offset: 0x00440D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationPush()
		{
		}

		// Token: 0x0601D1FB RID: 119291 RVA: 0x00442B4E File Offset: 0x00440D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationPush(AiInformationPush other) : this()
		{
			this.aiInfo_ = ((other.aiInfo_ != null) ? other.aiInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D1FC RID: 119292 RVA: 0x00442B83 File Offset: 0x00440D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationPush Clone()
		{
			return new AiInformationPush(this);
		}

		// Token: 0x170062CD RID: 25293
		// (get) Token: 0x0601D1FD RID: 119293 RVA: 0x00442B8B File Offset: 0x00440D8B
		// (set) Token: 0x0601D1FE RID: 119294 RVA: 0x00442B93 File Offset: 0x00440D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformation AiInfo
		{
			get
			{
				return this.aiInfo_;
			}
			set
			{
				this.aiInfo_ = value;
			}
		}

		// Token: 0x0601D1FF RID: 119295 RVA: 0x00442B9C File Offset: 0x00440D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiInformationPush);
		}

		// Token: 0x0601D200 RID: 119296 RVA: 0x00442BAA File Offset: 0x00440DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiInformationPush other)
		{
			return other != null && (other == this || (object.Equals(this.AiInfo, other.AiInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D201 RID: 119297 RVA: 0x00442BE0 File Offset: 0x00440DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.aiInfo_ != null)
			{
				num ^= this.AiInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D202 RID: 119298 RVA: 0x00442C1C File Offset: 0x00440E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D203 RID: 119299 RVA: 0x00442C29 File Offset: 0x00440E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D204 RID: 119300 RVA: 0x00442C32 File Offset: 0x00440E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aiInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AiInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D205 RID: 119301 RVA: 0x00442C64 File Offset: 0x00440E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.aiInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AiInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D206 RID: 119302 RVA: 0x00442CA4 File Offset: 0x00440EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiInformationPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.aiInfo_ != null)
			{
				if (this.aiInfo_ == null)
				{
					this.AiInfo = new AiInformation();
				}
				this.AiInfo.MergeFrom(other.AiInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D207 RID: 119303 RVA: 0x00442CF8 File Offset: 0x00440EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D208 RID: 119304 RVA: 0x00442D04 File Offset: 0x00440F04
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.aiInfo_ == null)
					{
						this.AiInfo = new AiInformation();
					}
					input.ReadMessage(this.AiInfo);
				}
			}
		}

		// Token: 0x0400C45D RID: 50269
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C45E RID: 50270
		public const int AiInfoFieldNumber = 4;

		// Token: 0x0400C45F RID: 50271
		private AiInformation aiInfo_;
	}
}
