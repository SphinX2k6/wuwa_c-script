using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000790 RID: 1936
	[NetMessage(EMessageId.HonamiStoryMascotRewardResponse)]
	public sealed class HonamiStoryMascotRewardResponse : IMessage<HonamiStoryMascotRewardResponse>, IMessage, IEquatable<HonamiStoryMascotRewardResponse>, IDeepCloneable<HonamiStoryMascotRewardResponse>, IBufferMessage
	{
		// Token: 0x0600AEC7 RID: 44743 RVA: 0x001A3CA9 File Offset: 0x001A1EA9
		[NullableContext(1)]
		public static HonamiStoryMascotRewardResponse Create()
		{
			return new HonamiStoryMascotRewardResponse();
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x0600AEC8 RID: 44744 RVA: 0x001A3CB0 File Offset: 0x001A1EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x0600AEC9 RID: 44745 RVA: 0x001A3CB3 File Offset: 0x001A1EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryMascotRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600AECA RID: 44746 RVA: 0x001A3CBA File Offset: 0x001A1EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardResponse()
		{
		}

		// Token: 0x0600AECB RID: 44747 RVA: 0x001A3CC2 File Offset: 0x001A1EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardResponse(HonamiStoryMascotRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AECC RID: 44748 RVA: 0x001A3CE7 File Offset: 0x001A1EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardResponse Clone()
		{
			return new HonamiStoryMascotRewardResponse(this);
		}

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x0600AECD RID: 44749 RVA: 0x001A3CEF File Offset: 0x001A1EEF
		// (set) Token: 0x0600AECE RID: 44750 RVA: 0x001A3CF7 File Offset: 0x001A1EF7
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

		// Token: 0x0600AECF RID: 44751 RVA: 0x001A3D00 File Offset: 0x001A1F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryMascotRewardResponse);
		}

		// Token: 0x0600AED0 RID: 44752 RVA: 0x001A3D0E File Offset: 0x001A1F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryMascotRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AED1 RID: 44753 RVA: 0x001A3D3C File Offset: 0x001A1F3C
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

		// Token: 0x0600AED2 RID: 44754 RVA: 0x001A3D81 File Offset: 0x001A1F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x001A3D8E File Offset: 0x001A1F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x001A3D97 File Offset: 0x001A1F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AED5 RID: 44757 RVA: 0x001A3DCC File Offset: 0x001A1FCC
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

		// Token: 0x0600AED6 RID: 44758 RVA: 0x001A3E0A File Offset: 0x001A200A
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

		// Token: 0x0600AED7 RID: 44759 RVA: 0x001A3E3B File Offset: 0x001A203B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AED8 RID: 44760 RVA: 0x001A3E44 File Offset: 0x001A2044
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004ED2 RID: 20178
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ED3 RID: 20179
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04004ED4 RID: 20180
		private ErrorCode errorCode_;
	}
}
