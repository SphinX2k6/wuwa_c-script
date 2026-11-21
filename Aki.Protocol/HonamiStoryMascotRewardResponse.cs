using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077C RID: 1916
	[NetMessage(EMessageId.HonamiStoryMascotRewardResponse)]
	public sealed class HonamiStoryMascotRewardResponse : IMessage<HonamiStoryMascotRewardResponse>, IMessage, IEquatable<HonamiStoryMascotRewardResponse>, IDeepCloneable<HonamiStoryMascotRewardResponse>, IBufferMessage
	{
		// Token: 0x0600AD71 RID: 44401 RVA: 0x001A1281 File Offset: 0x0019F481
		[NullableContext(1)]
		public static HonamiStoryMascotRewardResponse Create()
		{
			return new HonamiStoryMascotRewardResponse();
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x0600AD72 RID: 44402 RVA: 0x001A1288 File Offset: 0x0019F488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x0600AD73 RID: 44403 RVA: 0x001A128B File Offset: 0x0019F48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryMascotRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600AD74 RID: 44404 RVA: 0x001A1292 File Offset: 0x0019F492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardResponse()
		{
		}

		// Token: 0x0600AD75 RID: 44405 RVA: 0x001A129A File Offset: 0x0019F49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardResponse(HonamiStoryMascotRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD76 RID: 44406 RVA: 0x001A12BF File Offset: 0x0019F4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardResponse Clone()
		{
			return new HonamiStoryMascotRewardResponse(this);
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x0600AD77 RID: 44407 RVA: 0x001A12C7 File Offset: 0x0019F4C7
		// (set) Token: 0x0600AD78 RID: 44408 RVA: 0x001A12CF File Offset: 0x0019F4CF
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

		// Token: 0x0600AD79 RID: 44409 RVA: 0x001A12D8 File Offset: 0x0019F4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryMascotRewardResponse);
		}

		// Token: 0x0600AD7A RID: 44410 RVA: 0x001A12E6 File Offset: 0x0019F4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryMascotRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD7B RID: 44411 RVA: 0x001A1314 File Offset: 0x0019F514
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

		// Token: 0x0600AD7C RID: 44412 RVA: 0x001A1359 File Offset: 0x0019F559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD7D RID: 44413 RVA: 0x001A1366 File Offset: 0x0019F566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD7E RID: 44414 RVA: 0x001A136F File Offset: 0x0019F56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD7F RID: 44415 RVA: 0x001A13A4 File Offset: 0x0019F5A4
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

		// Token: 0x0600AD80 RID: 44416 RVA: 0x001A13E2 File Offset: 0x0019F5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryMascotRewardResponse other)
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

		// Token: 0x0600AD81 RID: 44417 RVA: 0x001A1413 File Offset: 0x0019F613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD82 RID: 44418 RVA: 0x001A141C File Offset: 0x0019F61C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004ECB RID: 20171
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ECC RID: 20172
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004ECD RID: 20173
		private ErrorCode errorCode_;
	}
}
