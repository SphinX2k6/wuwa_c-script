using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000984 RID: 2436
	[NetMessage(EMessageId.MapReplaceMarkRequest)]
	public sealed class MapReplaceMarkRequest : IMessage<MapReplaceMarkRequest>, IMessage, IEquatable<MapReplaceMarkRequest>, IDeepCloneable<MapReplaceMarkRequest>, IBufferMessage
	{
		// Token: 0x0600D670 RID: 54896 RVA: 0x001F8E40 File Offset: 0x001F7040
		[NullableContext(1)]
		public static MapReplaceMarkRequest Create()
		{
			return new MapReplaceMarkRequest();
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x0600D671 RID: 54897 RVA: 0x001F8E47 File Offset: 0x001F7047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x0600D672 RID: 54898 RVA: 0x001F8E4A File Offset: 0x001F704A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapReplaceMarkRequest.Descriptor;
			}
		}

		// Token: 0x0600D673 RID: 54899 RVA: 0x001F8E51 File Offset: 0x001F7051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkRequest()
		{
		}

		// Token: 0x0600D674 RID: 54900 RVA: 0x001F8E59 File Offset: 0x001F7059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkRequest(MapReplaceMarkRequest other) : this()
		{
			this.markId_ = other.markId_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D675 RID: 54901 RVA: 0x001F8E8A File Offset: 0x001F708A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkRequest Clone()
		{
			return new MapReplaceMarkRequest(this);
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x0600D676 RID: 54902 RVA: 0x001F8E92 File Offset: 0x001F7092
		// (set) Token: 0x0600D677 RID: 54903 RVA: 0x001F8E9A File Offset: 0x001F709A
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

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x0600D678 RID: 54904 RVA: 0x001F8EA3 File Offset: 0x001F70A3
		// (set) Token: 0x0600D679 RID: 54905 RVA: 0x001F8EAB File Offset: 0x001F70AB
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

		// Token: 0x0600D67A RID: 54906 RVA: 0x001F8EB4 File Offset: 0x001F70B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapReplaceMarkRequest);
		}

		// Token: 0x0600D67B RID: 54907 RVA: 0x001F8EC2 File Offset: 0x001F70C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapReplaceMarkRequest other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D67C RID: 54908 RVA: 0x001F8F00 File Offset: 0x001F7100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600D67D RID: 54909 RVA: 0x001F8F58 File Offset: 0x001F7158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D67E RID: 54910 RVA: 0x001F8F65 File Offset: 0x001F7165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D67F RID: 54911 RVA: 0x001F8F70 File Offset: 0x001F7170
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D680 RID: 54912 RVA: 0x001F8FCC File Offset: 0x001F71CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600D681 RID: 54913 RVA: 0x001F9024 File Offset: 0x001F7224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapReplaceMarkRequest other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0600D682 RID: 54914 RVA: 0x001F9074 File Offset: 0x001F7274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D683 RID: 54915 RVA: 0x001F9080 File Offset: 0x001F7280
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x040059FB RID: 23035
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059FC RID: 23036
		public const int MarkIdFieldNumber = 10;

		// Token: 0x040059FD RID: 23037
		private int markId_;

		// Token: 0x040059FE RID: 23038
		public const int ConfigIdFieldNumber = 6;

		// Token: 0x040059FF RID: 23039
		private int configId_;
	}
}
