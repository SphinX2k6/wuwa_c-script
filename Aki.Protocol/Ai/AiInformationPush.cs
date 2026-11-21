using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001731 RID: 5937
	[NetMessage(EMessageId.AiInformationPush)]
	public sealed class AiInformationPush : IMessage<AiInformationPush>, IMessage, IEquatable<AiInformationPush>, IDeepCloneable<AiInformationPush>, IBufferMessage
	{
		// Token: 0x0601DCC6 RID: 122054 RVA: 0x0045E875 File Offset: 0x0045CA75
		[NullableContext(1)]
		public static AiInformationPush Create()
		{
			return new AiInformationPush();
		}

		// Token: 0x17006570 RID: 25968
		// (get) Token: 0x0601DCC7 RID: 122055 RVA: 0x0045E87C File Offset: 0x0045CA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006571 RID: 25969
		// (get) Token: 0x0601DCC8 RID: 122056 RVA: 0x0045E87F File Offset: 0x0045CA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiInformationPush.Descriptor;
			}
		}

		// Token: 0x0601DCC9 RID: 122057 RVA: 0x0045E886 File Offset: 0x0045CA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationPush()
		{
		}

		// Token: 0x0601DCCA RID: 122058 RVA: 0x0045E88E File Offset: 0x0045CA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationPush(AiInformationPush other) : this()
		{
			this.aiInfo_ = ((other.aiInfo_ != null) ? other.aiInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DCCB RID: 122059 RVA: 0x0045E8C3 File Offset: 0x0045CAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationPush Clone()
		{
			return new AiInformationPush(this);
		}

		// Token: 0x17006572 RID: 25970
		// (get) Token: 0x0601DCCC RID: 122060 RVA: 0x0045E8CB File Offset: 0x0045CACB
		// (set) Token: 0x0601DCCD RID: 122061 RVA: 0x0045E8D3 File Offset: 0x0045CAD3
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

		// Token: 0x0601DCCE RID: 122062 RVA: 0x0045E8DC File Offset: 0x0045CADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiInformationPush);
		}

		// Token: 0x0601DCCF RID: 122063 RVA: 0x0045E8EA File Offset: 0x0045CAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiInformationPush other)
		{
			return other != null && (other == this || (object.Equals(this.AiInfo, other.AiInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DCD0 RID: 122064 RVA: 0x0045E920 File Offset: 0x0045CB20
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

		// Token: 0x0601DCD1 RID: 122065 RVA: 0x0045E95C File Offset: 0x0045CB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DCD2 RID: 122066 RVA: 0x0045E969 File Offset: 0x0045CB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DCD3 RID: 122067 RVA: 0x0045E972 File Offset: 0x0045CB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aiInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.AiInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DCD4 RID: 122068 RVA: 0x0045E9A4 File Offset: 0x0045CBA4
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

		// Token: 0x0601DCD5 RID: 122069 RVA: 0x0045E9E4 File Offset: 0x0045CBE4
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

		// Token: 0x0601DCD6 RID: 122070 RVA: 0x0045EA38 File Offset: 0x0045CC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DCD7 RID: 122071 RVA: 0x0045EA44 File Offset: 0x0045CC44
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
				if (num != 74U)
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

		// Token: 0x0400C98C RID: 51596
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C98D RID: 51597
		public const int AiInfoFieldNumber = 9;

		// Token: 0x0400C98E RID: 51598
		private AiInformation aiInfo_;
	}
}
