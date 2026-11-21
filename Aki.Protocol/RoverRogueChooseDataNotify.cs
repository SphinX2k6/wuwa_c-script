using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001130 RID: 4400
	[NetMessage(EMessageId.RoverRogueChooseDataNotify)]
	public sealed class RoverRogueChooseDataNotify : IMessage<RoverRogueChooseDataNotify>, IMessage, IEquatable<RoverRogueChooseDataNotify>, IDeepCloneable<RoverRogueChooseDataNotify>, IBufferMessage
	{
		// Token: 0x06017822 RID: 96290 RVA: 0x0036BA2C File Offset: 0x00369C2C
		[NullableContext(1)]
		public static RoverRogueChooseDataNotify Create()
		{
			return new RoverRogueChooseDataNotify();
		}

		// Token: 0x17004F04 RID: 20228
		// (get) Token: 0x06017823 RID: 96291 RVA: 0x0036BA33 File Offset: 0x00369C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F05 RID: 20229
		// (get) Token: 0x06017824 RID: 96292 RVA: 0x0036BA36 File Offset: 0x00369C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueChooseDataNotify.Descriptor;
			}
		}

		// Token: 0x06017825 RID: 96293 RVA: 0x0036BA3D File Offset: 0x00369C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataNotify()
		{
		}

		// Token: 0x06017826 RID: 96294 RVA: 0x0036BA45 File Offset: 0x00369C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataNotify(RoverRogueChooseDataNotify other) : this()
		{
			this.chooseData_ = ((other.chooseData_ != null) ? other.chooseData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017827 RID: 96295 RVA: 0x0036BA7A File Offset: 0x00369C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataNotify Clone()
		{
			return new RoverRogueChooseDataNotify(this);
		}

		// Token: 0x17004F06 RID: 20230
		// (get) Token: 0x06017828 RID: 96296 RVA: 0x0036BA82 File Offset: 0x00369C82
		// (set) Token: 0x06017829 RID: 96297 RVA: 0x0036BA8A File Offset: 0x00369C8A
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

		// Token: 0x0601782A RID: 96298 RVA: 0x0036BA93 File Offset: 0x00369C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueChooseDataNotify);
		}

		// Token: 0x0601782B RID: 96299 RVA: 0x0036BAA1 File Offset: 0x00369CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueChooseDataNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ChooseData, other.ChooseData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601782C RID: 96300 RVA: 0x0036BAD4 File Offset: 0x00369CD4
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

		// Token: 0x0601782D RID: 96301 RVA: 0x0036BB10 File Offset: 0x00369D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601782E RID: 96302 RVA: 0x0036BB1D File Offset: 0x00369D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601782F RID: 96303 RVA: 0x0036BB26 File Offset: 0x00369D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.chooseData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ChooseData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017830 RID: 96304 RVA: 0x0036BB58 File Offset: 0x00369D58
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

		// Token: 0x06017831 RID: 96305 RVA: 0x0036BB98 File Offset: 0x00369D98
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

		// Token: 0x06017832 RID: 96306 RVA: 0x0036BBEC File Offset: 0x00369DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017833 RID: 96307 RVA: 0x0036BBF8 File Offset: 0x00369DF8
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
					if (this.chooseData_ == null)
					{
						this.ChooseData = new RoverRogueChooseData();
					}
					input.ReadMessage(this.ChooseData);
				}
			}
		}

		// Token: 0x04008C54 RID: 35924
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C55 RID: 35925
		public const int ChooseDataFieldNumber = 9;

		// Token: 0x04008C56 RID: 35926
		private RoverRogueChooseData chooseData_;
	}
}
