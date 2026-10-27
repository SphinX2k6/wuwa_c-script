using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000995 RID: 2453
	[NetMessage(EMessageId.MapReplaceMarkRequest)]
	public sealed class MapReplaceMarkRequest : IMessage<MapReplaceMarkRequest>, IMessage, IEquatable<MapReplaceMarkRequest>, IDeepCloneable<MapReplaceMarkRequest>, IBufferMessage
	{
		// Token: 0x0600D78A RID: 55178 RVA: 0x001FB02F File Offset: 0x001F922F
		[NullableContext(1)]
		public static MapReplaceMarkRequest Create()
		{
			return new MapReplaceMarkRequest();
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x0600D78B RID: 55179 RVA: 0x001FB036 File Offset: 0x001F9236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x0600D78C RID: 55180 RVA: 0x001FB039 File Offset: 0x001F9239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapReplaceMarkRequest.Descriptor;
			}
		}

		// Token: 0x0600D78D RID: 55181 RVA: 0x001FB040 File Offset: 0x001F9240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkRequest()
		{
		}

		// Token: 0x0600D78E RID: 55182 RVA: 0x001FB048 File Offset: 0x001F9248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkRequest(MapReplaceMarkRequest other) : this()
		{
			this.markId_ = other.markId_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D78F RID: 55183 RVA: 0x001FB079 File Offset: 0x001F9279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapReplaceMarkRequest Clone()
		{
			return new MapReplaceMarkRequest(this);
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x0600D790 RID: 55184 RVA: 0x001FB081 File Offset: 0x001F9281
		// (set) Token: 0x0600D791 RID: 55185 RVA: 0x001FB089 File Offset: 0x001F9289
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

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x0600D792 RID: 55186 RVA: 0x001FB092 File Offset: 0x001F9292
		// (set) Token: 0x0600D793 RID: 55187 RVA: 0x001FB09A File Offset: 0x001F929A
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

		// Token: 0x0600D794 RID: 55188 RVA: 0x001FB0A3 File Offset: 0x001F92A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapReplaceMarkRequest);
		}

		// Token: 0x0600D795 RID: 55189 RVA: 0x001FB0B1 File Offset: 0x001F92B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapReplaceMarkRequest other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D796 RID: 55190 RVA: 0x001FB0F0 File Offset: 0x001F92F0
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

		// Token: 0x0600D797 RID: 55191 RVA: 0x001FB148 File Offset: 0x001F9348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D798 RID: 55192 RVA: 0x001FB155 File Offset: 0x001F9355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D799 RID: 55193 RVA: 0x001FB160 File Offset: 0x001F9360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MarkId);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D79A RID: 55194 RVA: 0x001FB1BC File Offset: 0x001F93BC
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

		// Token: 0x0600D79B RID: 55195 RVA: 0x001FB214 File Offset: 0x001F9414
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

		// Token: 0x0600D79C RID: 55196 RVA: 0x001FB264 File Offset: 0x001F9464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D79D RID: 55197 RVA: 0x001FB270 File Offset: 0x001F9470
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
				if (num != 24U)
				{
					if (num != 32U)
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
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040059F2 RID: 23026
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059F3 RID: 23027
		public const int MarkIdFieldNumber = 3;

		// Token: 0x040059F4 RID: 23028
		private int markId_;

		// Token: 0x040059F5 RID: 23029
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x040059F6 RID: 23030
		private int configId_;
	}
}
