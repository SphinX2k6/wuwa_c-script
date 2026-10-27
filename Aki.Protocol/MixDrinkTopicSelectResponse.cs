using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E1 RID: 2529
	[NetMessage(EMessageId.MixDrinkTopicSelectResponse)]
	public sealed class MixDrinkTopicSelectResponse : IMessage<MixDrinkTopicSelectResponse>, IMessage, IEquatable<MixDrinkTopicSelectResponse>, IDeepCloneable<MixDrinkTopicSelectResponse>, IBufferMessage
	{
		// Token: 0x0600DD9B RID: 56731 RVA: 0x00208155 File Offset: 0x00206355
		[NullableContext(1)]
		public static MixDrinkTopicSelectResponse Create()
		{
			return new MixDrinkTopicSelectResponse();
		}

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x0600DD9C RID: 56732 RVA: 0x0020815C File Offset: 0x0020635C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x0600DD9D RID: 56733 RVA: 0x0020815F File Offset: 0x0020635F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkTopicSelectResponse.Descriptor;
			}
		}

		// Token: 0x0600DD9E RID: 56734 RVA: 0x00208166 File Offset: 0x00206366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectResponse()
		{
		}

		// Token: 0x0600DD9F RID: 56735 RVA: 0x0020816E File Offset: 0x0020636E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectResponse(MixDrinkTopicSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDA0 RID: 56736 RVA: 0x00208193 File Offset: 0x00206393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectResponse Clone()
		{
			return new MixDrinkTopicSelectResponse(this);
		}

		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x0600DDA1 RID: 56737 RVA: 0x0020819B File Offset: 0x0020639B
		// (set) Token: 0x0600DDA2 RID: 56738 RVA: 0x002081A3 File Offset: 0x002063A3
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

		// Token: 0x0600DDA3 RID: 56739 RVA: 0x002081AC File Offset: 0x002063AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkTopicSelectResponse);
		}

		// Token: 0x0600DDA4 RID: 56740 RVA: 0x002081BA File Offset: 0x002063BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkTopicSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDA5 RID: 56741 RVA: 0x002081E8 File Offset: 0x002063E8
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

		// Token: 0x0600DDA6 RID: 56742 RVA: 0x0020822D File Offset: 0x0020642D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DDA7 RID: 56743 RVA: 0x0020823A File Offset: 0x0020643A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DDA8 RID: 56744 RVA: 0x00208243 File Offset: 0x00206443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DDA9 RID: 56745 RVA: 0x00208278 File Offset: 0x00206478
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

		// Token: 0x0600DDAA RID: 56746 RVA: 0x002082B6 File Offset: 0x002064B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MixDrinkTopicSelectResponse other)
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

		// Token: 0x0600DDAB RID: 56747 RVA: 0x002082E7 File Offset: 0x002064E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DDAC RID: 56748 RVA: 0x002082F0 File Offset: 0x002064F0
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B9B RID: 23451
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B9C RID: 23452
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04005B9D RID: 23453
		private ErrorCode errorCode_;
	}
}
