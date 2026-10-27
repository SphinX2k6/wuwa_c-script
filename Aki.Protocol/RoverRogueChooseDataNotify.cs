using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F6 RID: 4342
	[NetMessage(EMessageId.RoverRogueChooseDataNotify)]
	public sealed class RoverRogueChooseDataNotify : IMessage<RoverRogueChooseDataNotify>, IMessage, IEquatable<RoverRogueChooseDataNotify>, IDeepCloneable<RoverRogueChooseDataNotify>, IBufferMessage
	{
		// Token: 0x06017281 RID: 94849 RVA: 0x0035C6D4 File Offset: 0x0035A8D4
		[NullableContext(1)]
		public static RoverRogueChooseDataNotify Create()
		{
			return new RoverRogueChooseDataNotify();
		}

		// Token: 0x17004D98 RID: 19864
		// (get) Token: 0x06017282 RID: 94850 RVA: 0x0035C6DB File Offset: 0x0035A8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D99 RID: 19865
		// (get) Token: 0x06017283 RID: 94851 RVA: 0x0035C6DE File Offset: 0x0035A8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueChooseDataNotify.Descriptor;
			}
		}

		// Token: 0x06017284 RID: 94852 RVA: 0x0035C6E5 File Offset: 0x0035A8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataNotify()
		{
		}

		// Token: 0x06017285 RID: 94853 RVA: 0x0035C6ED File Offset: 0x0035A8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataNotify(RoverRogueChooseDataNotify other) : this()
		{
			this.chooseData_ = ((other.chooseData_ != null) ? other.chooseData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017286 RID: 94854 RVA: 0x0035C722 File Offset: 0x0035A922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataNotify Clone()
		{
			return new RoverRogueChooseDataNotify(this);
		}

		// Token: 0x17004D9A RID: 19866
		// (get) Token: 0x06017287 RID: 94855 RVA: 0x0035C72A File Offset: 0x0035A92A
		// (set) Token: 0x06017288 RID: 94856 RVA: 0x0035C732 File Offset: 0x0035A932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseData ChooseData
		{
			get
			{
				return this.chooseData_;
			}
			set
			{
				this.chooseData_ = value;
			}
		}

		// Token: 0x06017289 RID: 94857 RVA: 0x0035C73B File Offset: 0x0035A93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueChooseDataNotify);
		}

		// Token: 0x0601728A RID: 94858 RVA: 0x0035C749 File Offset: 0x0035A949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueChooseDataNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ChooseData, other.ChooseData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601728B RID: 94859 RVA: 0x0035C77C File Offset: 0x0035A97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.chooseData_ != null)
			{
				num ^= this.ChooseData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601728C RID: 94860 RVA: 0x0035C7B8 File Offset: 0x0035A9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601728D RID: 94861 RVA: 0x0035C7C5 File Offset: 0x0035A9C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601728E RID: 94862 RVA: 0x0035C7CE File Offset: 0x0035A9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.chooseData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ChooseData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601728F RID: 94863 RVA: 0x0035C800 File Offset: 0x0035AA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.chooseData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChooseData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017290 RID: 94864 RVA: 0x0035C840 File Offset: 0x0035AA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueChooseDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.chooseData_ != null)
			{
				if (this.chooseData_ == null)
				{
					this.ChooseData = new RoverRogueChooseData();
				}
				this.ChooseData.MergeFrom(other.ChooseData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017291 RID: 94865 RVA: 0x0035C894 File Offset: 0x0035AA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017292 RID: 94866 RVA: 0x0035C8A0 File Offset: 0x0035AAA0
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.chooseData_ == null)
					{
						this.ChooseData = new RoverRogueChooseData();
					}
					input.ReadMessage(this.ChooseData);
				}
			}
		}

		// Token: 0x040089C1 RID: 35265
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089C2 RID: 35266
		public const int ChooseDataFieldNumber = 3;

		// Token: 0x040089C3 RID: 35267
		private RoverRogueChooseData chooseData_;
	}
}
