using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A19 RID: 2585
	[NetMessage(EMessageId.MoralePosResponse)]
	public sealed class MoralePosResponse : IMessage<MoralePosResponse>, IMessage, IEquatable<MoralePosResponse>, IDeepCloneable<MoralePosResponse>, IBufferMessage
	{
		// Token: 0x0600E21A RID: 57882 RVA: 0x00211DAE File Offset: 0x0020FFAE
		[NullableContext(1)]
		public static MoralePosResponse Create()
		{
			return new MoralePosResponse();
		}

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x0600E21B RID: 57883 RVA: 0x00211DB5 File Offset: 0x0020FFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x0600E21C RID: 57884 RVA: 0x00211DB8 File Offset: 0x0020FFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoralePosResponse.Descriptor;
			}
		}

		// Token: 0x0600E21D RID: 57885 RVA: 0x00211DBF File Offset: 0x0020FFBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosResponse()
		{
		}

		// Token: 0x0600E21E RID: 57886 RVA: 0x00211DC7 File Offset: 0x0020FFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosResponse(MoralePosResponse other) : this()
		{
			this.areaPos_ = other.areaPos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E21F RID: 57887 RVA: 0x00211DEC File Offset: 0x0020FFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosResponse Clone()
		{
			return new MoralePosResponse(this);
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x0600E220 RID: 57888 RVA: 0x00211DF4 File Offset: 0x0020FFF4
		// (set) Token: 0x0600E221 RID: 57889 RVA: 0x00211DFC File Offset: 0x0020FFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaPos
		{
			get
			{
				return this.areaPos_;
			}
			set
			{
				this.areaPos_ = value;
			}
		}

		// Token: 0x0600E222 RID: 57890 RVA: 0x00211E05 File Offset: 0x00210005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoralePosResponse);
		}

		// Token: 0x0600E223 RID: 57891 RVA: 0x00211E13 File Offset: 0x00210013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoralePosResponse other)
		{
			return other != null && (other == this || (this.AreaPos == other.AreaPos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E224 RID: 57892 RVA: 0x00211E44 File Offset: 0x00210044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaPos != 0)
			{
				num ^= this.AreaPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E225 RID: 57893 RVA: 0x00211E83 File Offset: 0x00210083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E226 RID: 57894 RVA: 0x00211E90 File Offset: 0x00210090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E227 RID: 57895 RVA: 0x00211E99 File Offset: 0x00210099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaPos != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AreaPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E228 RID: 57896 RVA: 0x00211ECC File Offset: 0x002100CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaPos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E229 RID: 57897 RVA: 0x00211F0A File Offset: 0x0021010A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoralePosResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaPos != 0)
			{
				this.AreaPos = other.AreaPos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E22A RID: 57898 RVA: 0x00211F3B File Offset: 0x0021013B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E22B RID: 57899 RVA: 0x00211F44 File Offset: 0x00210144
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AreaPos = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005CDF RID: 23775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CE0 RID: 23776
		public const int AreaPosFieldNumber = 1;

		// Token: 0x04005CE1 RID: 23777
		private int areaPos_;
	}
}
