using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200158F RID: 5519
	[NetMessage(EMessageId.WorldEnterPermissionsResponse)]
	public sealed class WorldEnterPermissionsResponse : IMessage<WorldEnterPermissionsResponse>, IMessage, IEquatable<WorldEnterPermissionsResponse>, IDeepCloneable<WorldEnterPermissionsResponse>, IBufferMessage
	{
		// Token: 0x0601D366 RID: 119654 RVA: 0x0043A89D File Offset: 0x00438A9D
		[NullableContext(1)]
		public static WorldEnterPermissionsResponse Create()
		{
			return new WorldEnterPermissionsResponse();
		}

		// Token: 0x170062D1 RID: 25297
		// (get) Token: 0x0601D367 RID: 119655 RVA: 0x0043A8A4 File Offset: 0x00438AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062D2 RID: 25298
		// (get) Token: 0x0601D368 RID: 119656 RVA: 0x0043A8A7 File Offset: 0x00438AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldEnterPermissionsResponse.Descriptor;
			}
		}

		// Token: 0x0601D369 RID: 119657 RVA: 0x0043A8AE File Offset: 0x00438AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsResponse()
		{
		}

		// Token: 0x0601D36A RID: 119658 RVA: 0x0043A8B6 File Offset: 0x00438AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsResponse(WorldEnterPermissionsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D36B RID: 119659 RVA: 0x0043A8E7 File Offset: 0x00438AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsResponse Clone()
		{
			return new WorldEnterPermissionsResponse(this);
		}

		// Token: 0x170062D3 RID: 25299
		// (get) Token: 0x0601D36C RID: 119660 RVA: 0x0043A8EF File Offset: 0x00438AEF
		// (set) Token: 0x0601D36D RID: 119661 RVA: 0x0043A8F7 File Offset: 0x00438AF7
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

		// Token: 0x170062D4 RID: 25300
		// (get) Token: 0x0601D36E RID: 119662 RVA: 0x0043A900 File Offset: 0x00438B00
		// (set) Token: 0x0601D36F RID: 119663 RVA: 0x0043A908 File Offset: 0x00438B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermission Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x0601D370 RID: 119664 RVA: 0x0043A911 File Offset: 0x00438B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldEnterPermissionsResponse);
		}

		// Token: 0x0601D371 RID: 119665 RVA: 0x0043A91F File Offset: 0x00438B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldEnterPermissionsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D372 RID: 119666 RVA: 0x0043A960 File Offset: 0x00438B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Type != WorldEnterPermission.ConfirmJoin)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D373 RID: 119667 RVA: 0x0043A9C4 File Offset: 0x00438BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D374 RID: 119668 RVA: 0x0043A9D1 File Offset: 0x00438BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D375 RID: 119669 RVA: 0x0043A9DC File Offset: 0x00438BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != WorldEnterPermission.ConfirmJoin)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Type);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D376 RID: 119670 RVA: 0x0043AA38 File Offset: 0x00438C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Type != WorldEnterPermission.ConfirmJoin)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D377 RID: 119671 RVA: 0x0043AA90 File Offset: 0x00438C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldEnterPermissionsResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Type != WorldEnterPermission.ConfirmJoin)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D378 RID: 119672 RVA: 0x0043AAE0 File Offset: 0x00438CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D379 RID: 119673 RVA: 0x0043AAEC File Offset: 0x00438CEC
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
				if (num != 56U)
				{
					if (num != 112U)
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
					this.Type = (WorldEnterPermission)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A791 RID: 42897
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A792 RID: 42898
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400A793 RID: 42899
		private ErrorCode errorCode_;

		// Token: 0x0400A794 RID: 42900
		public const int TypeFieldNumber = 7;

		// Token: 0x0400A795 RID: 42901
		private WorldEnterPermission type_;
	}
}
