using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000985 RID: 2437
	[NetMessage(EMessageId.MapReplaceMarkResponse)]
	public sealed class MapReplaceMarkResponse : IMessage<MapReplaceMarkResponse>, IMessage, IEquatable<MapReplaceMarkResponse>, IDeepCloneable<MapReplaceMarkResponse>, IBufferMessage
	{
		// Token: 0x0600D684 RID: 54916 RVA: 0x001F90D8 File Offset: 0x001F72D8
		[NullableContext(1)]
		public static MapReplaceMarkResponse Create()
		{
			return new MapReplaceMarkResponse();
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x0600D685 RID: 54917 RVA: 0x001F90DF File Offset: 0x001F72DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x0600D686 RID: 54918 RVA: 0x001F90E2 File Offset: 0x001F72E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapReplaceMarkResponse.Descriptor;
			}
		}

		// Token: 0x0600D687 RID: 54919 RVA: 0x001F90E9 File Offset: 0x001F72E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkResponse()
		{
		}

		// Token: 0x0600D688 RID: 54920 RVA: 0x001F90F1 File Offset: 0x001F72F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkResponse(MapReplaceMarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markId_ = other.markId_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D689 RID: 54921 RVA: 0x001F912E File Offset: 0x001F732E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkResponse Clone()
		{
			return new MapReplaceMarkResponse(this);
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x0600D68A RID: 54922 RVA: 0x001F9136 File Offset: 0x001F7336
		// (set) Token: 0x0600D68B RID: 54923 RVA: 0x001F913E File Offset: 0x001F733E
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

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x0600D68C RID: 54924 RVA: 0x001F9147 File Offset: 0x001F7347
		// (set) Token: 0x0600D68D RID: 54925 RVA: 0x001F914F File Offset: 0x001F734F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x0600D68E RID: 54926 RVA: 0x001F9158 File Offset: 0x001F7358
		// (set) Token: 0x0600D68F RID: 54927 RVA: 0x001F9160 File Offset: 0x001F7360
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

		// Token: 0x0600D690 RID: 54928 RVA: 0x001F9169 File Offset: 0x001F7369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapReplaceMarkResponse);
		}

		// Token: 0x0600D691 RID: 54929 RVA: 0x001F9178 File Offset: 0x001F7378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapReplaceMarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MarkId == other.MarkId && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D692 RID: 54930 RVA: 0x001F91D4 File Offset: 0x001F73D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D693 RID: 54931 RVA: 0x001F924B File Offset: 0x001F744B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D694 RID: 54932 RVA: 0x001F9258 File Offset: 0x001F7458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D695 RID: 54933 RVA: 0x001F9264 File Offset: 0x001F7464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConfigId);
			}
			if (this.MarkId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MarkId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D696 RID: 54934 RVA: 0x001F92DC File Offset: 0x001F74DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D697 RID: 54935 RVA: 0x001F934C File Offset: 0x001F754C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapReplaceMarkResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D698 RID: 54936 RVA: 0x001F93B0 File Offset: 0x001F75B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D699 RID: 54937 RVA: 0x001F93BC File Offset: 0x001F75BC
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
				if (num != 16U)
				{
					if (num != 56U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.MarkId = input.ReadInt32();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A00 RID: 23040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A01 RID: 23041
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04005A02 RID: 23042
		private ErrorCode errorCode_;

		// Token: 0x04005A03 RID: 23043
		public const int MarkIdFieldNumber = 7;

		// Token: 0x04005A04 RID: 23044
		private int markId_;

		// Token: 0x04005A05 RID: 23045
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x04005A06 RID: 23046
		private int configId_;
	}
}
