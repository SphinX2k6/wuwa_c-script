using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001245 RID: 4677
	[NetMessage(EMessageId.ShortMessageReplyRequest)]
	public sealed class ShortMessageReplyRequest : IMessage<ShortMessageReplyRequest>, IMessage, IEquatable<ShortMessageReplyRequest>, IDeepCloneable<ShortMessageReplyRequest>, IBufferMessage
	{
		// Token: 0x06018F9C RID: 102300 RVA: 0x003A4245 File Offset: 0x003A2445
		[NullableContext(1)]
		public static ShortMessageReplyRequest Create()
		{
			return new ShortMessageReplyRequest();
		}

		// Token: 0x17005467 RID: 21607
		// (get) Token: 0x06018F9D RID: 102301 RVA: 0x003A424C File Offset: 0x003A244C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005468 RID: 21608
		// (get) Token: 0x06018F9E RID: 102302 RVA: 0x003A424F File Offset: 0x003A244F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReplyRequest.Descriptor;
			}
		}

		// Token: 0x06018F9F RID: 102303 RVA: 0x003A4256 File Offset: 0x003A2456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyRequest()
		{
		}

		// Token: 0x06018FA0 RID: 102304 RVA: 0x003A425E File Offset: 0x003A245E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyRequest(ShortMessageReplyRequest other) : this()
		{
			this.configId_ = other.configId_;
			this.curOptionId_ = other.curOptionId_;
			this.selectId_ = other.selectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018FA1 RID: 102305 RVA: 0x003A429B File Offset: 0x003A249B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyRequest Clone()
		{
			return new ShortMessageReplyRequest(this);
		}

		// Token: 0x17005469 RID: 21609
		// (get) Token: 0x06018FA2 RID: 102306 RVA: 0x003A42A3 File Offset: 0x003A24A3
		// (set) Token: 0x06018FA3 RID: 102307 RVA: 0x003A42AB File Offset: 0x003A24AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x1700546A RID: 21610
		// (get) Token: 0x06018FA4 RID: 102308 RVA: 0x003A42B4 File Offset: 0x003A24B4
		// (set) Token: 0x06018FA5 RID: 102309 RVA: 0x003A42BC File Offset: 0x003A24BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurOptionId
		{
			get
			{
				return this.curOptionId_;
			}
			set
			{
				this.curOptionId_ = value;
			}
		}

		// Token: 0x1700546B RID: 21611
		// (get) Token: 0x06018FA6 RID: 102310 RVA: 0x003A42C5 File Offset: 0x003A24C5
		// (set) Token: 0x06018FA7 RID: 102311 RVA: 0x003A42CD File Offset: 0x003A24CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectId
		{
			get
			{
				return this.selectId_;
			}
			set
			{
				this.selectId_ = value;
			}
		}

		// Token: 0x06018FA8 RID: 102312 RVA: 0x003A42D6 File Offset: 0x003A24D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReplyRequest);
		}

		// Token: 0x06018FA9 RID: 102313 RVA: 0x003A42E4 File Offset: 0x003A24E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReplyRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.CurOptionId == other.CurOptionId && this.SelectId == other.SelectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018FAA RID: 102314 RVA: 0x003A4340 File Offset: 0x003A2540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.CurOptionId != 0)
			{
				num ^= this.CurOptionId.GetHashCode();
			}
			if (this.SelectId != 0)
			{
				num ^= this.SelectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018FAB RID: 102315 RVA: 0x003A43B1 File Offset: 0x003A25B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018FAC RID: 102316 RVA: 0x003A43BE File Offset: 0x003A25BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018FAD RID: 102317 RVA: 0x003A43C8 File Offset: 0x003A25C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SelectId);
			}
			if (this.CurOptionId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CurOptionId);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018FAE RID: 102318 RVA: 0x003A4440 File Offset: 0x003A2640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.CurOptionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurOptionId);
			}
			if (this.SelectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018FAF RID: 102319 RVA: 0x003A44B0 File Offset: 0x003A26B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReplyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.CurOptionId != 0)
			{
				this.CurOptionId = other.CurOptionId;
			}
			if (other.SelectId != 0)
			{
				this.SelectId = other.SelectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018FB0 RID: 102320 RVA: 0x003A4514 File Offset: 0x003A2714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018FB1 RID: 102321 RVA: 0x003A4520 File Offset: 0x003A2720
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
				if (num != 48U)
				{
					if (num != 88U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ConfigId = input.ReadInt32();
						}
					}
					else
					{
						this.CurOptionId = input.ReadInt32();
					}
				}
				else
				{
					this.SelectId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400941F RID: 37919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009420 RID: 37920
		public const int ConfigIdFieldNumber = 13;

		// Token: 0x04009421 RID: 37921
		private int configId_;

		// Token: 0x04009422 RID: 37922
		public const int CurOptionIdFieldNumber = 11;

		// Token: 0x04009423 RID: 37923
		private int curOptionId_;

		// Token: 0x04009424 RID: 37924
		public const int SelectIdFieldNumber = 6;

		// Token: 0x04009425 RID: 37925
		private int selectId_;
	}
}
