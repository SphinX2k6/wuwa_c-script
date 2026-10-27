using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000996 RID: 2454
	[NetMessage(EMessageId.MapReplaceMarkResponse)]
	public sealed class MapReplaceMarkResponse : IMessage<MapReplaceMarkResponse>, IMessage, IEquatable<MapReplaceMarkResponse>, IDeepCloneable<MapReplaceMarkResponse>, IBufferMessage
	{
		// Token: 0x0600D79E RID: 55198 RVA: 0x001FB2C8 File Offset: 0x001F94C8
		[NullableContext(1)]
		public static MapReplaceMarkResponse Create()
		{
			return new MapReplaceMarkResponse();
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x0600D79F RID: 55199 RVA: 0x001FB2CF File Offset: 0x001F94CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x0600D7A0 RID: 55200 RVA: 0x001FB2D2 File Offset: 0x001F94D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapReplaceMarkResponse.Descriptor;
			}
		}

		// Token: 0x0600D7A1 RID: 55201 RVA: 0x001FB2D9 File Offset: 0x001F94D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkResponse()
		{
		}

		// Token: 0x0600D7A2 RID: 55202 RVA: 0x001FB2E1 File Offset: 0x001F94E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkResponse(MapReplaceMarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markId_ = other.markId_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7A3 RID: 55203 RVA: 0x001FB31E File Offset: 0x001F951E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkResponse Clone()
		{
			return new MapReplaceMarkResponse(this);
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x0600D7A4 RID: 55204 RVA: 0x001FB326 File Offset: 0x001F9526
		// (set) Token: 0x0600D7A5 RID: 55205 RVA: 0x001FB32E File Offset: 0x001F952E
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

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x0600D7A6 RID: 55206 RVA: 0x001FB337 File Offset: 0x001F9537
		// (set) Token: 0x0600D7A7 RID: 55207 RVA: 0x001FB33F File Offset: 0x001F953F
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

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x0600D7A8 RID: 55208 RVA: 0x001FB348 File Offset: 0x001F9548
		// (set) Token: 0x0600D7A9 RID: 55209 RVA: 0x001FB350 File Offset: 0x001F9550
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

		// Token: 0x0600D7AA RID: 55210 RVA: 0x001FB359 File Offset: 0x001F9559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapReplaceMarkResponse);
		}

		// Token: 0x0600D7AB RID: 55211 RVA: 0x001FB368 File Offset: 0x001F9568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapReplaceMarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MarkId == other.MarkId && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7AC RID: 55212 RVA: 0x001FB3C4 File Offset: 0x001F95C4
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

		// Token: 0x0600D7AD RID: 55213 RVA: 0x001FB43B File Offset: 0x001F963B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D7AE RID: 55214 RVA: 0x001FB448 File Offset: 0x001F9648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7AF RID: 55215 RVA: 0x001FB454 File Offset: 0x001F9654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ConfigId);
			}
			if (this.MarkId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.MarkId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D7B0 RID: 55216 RVA: 0x001FB4CC File Offset: 0x001F96CC
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

		// Token: 0x0600D7B1 RID: 55217 RVA: 0x001FB53C File Offset: 0x001F973C
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

		// Token: 0x0600D7B2 RID: 55218 RVA: 0x001FB5A0 File Offset: 0x001F97A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7B3 RID: 55219 RVA: 0x001FB5AC File Offset: 0x001F97AC
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
					if (num != 80U)
					{
						if (num != 88U)
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

		// Token: 0x040059F7 RID: 23031
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059F8 RID: 23032
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040059F9 RID: 23033
		private ErrorCode errorCode_;

		// Token: 0x040059FA RID: 23034
		public const int MarkIdFieldNumber = 10;

		// Token: 0x040059FB RID: 23035
		private int markId_;

		// Token: 0x040059FC RID: 23036
		public const int ConfigIdFieldNumber = 6;

		// Token: 0x040059FD RID: 23037
		private int configId_;
	}
}
