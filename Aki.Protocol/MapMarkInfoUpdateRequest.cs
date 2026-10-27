using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098A RID: 2442
	[NetMessage(EMessageId.MapMarkInfoUpdateRequest)]
	public sealed class MapMarkInfoUpdateRequest : IMessage<MapMarkInfoUpdateRequest>, IMessage, IEquatable<MapMarkInfoUpdateRequest>, IDeepCloneable<MapMarkInfoUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600D6AC RID: 54956 RVA: 0x001F9241 File Offset: 0x001F7441
		[NullableContext(1)]
		public static MapMarkInfoUpdateRequest Create()
		{
			return new MapMarkInfoUpdateRequest();
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x0600D6AD RID: 54957 RVA: 0x001F9248 File Offset: 0x001F7448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x0600D6AE RID: 54958 RVA: 0x001F924B File Offset: 0x001F744B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkInfoUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600D6AF RID: 54959 RVA: 0x001F9252 File Offset: 0x001F7452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateRequest()
		{
		}

		// Token: 0x0600D6B0 RID: 54960 RVA: 0x001F925C File Offset: 0x001F745C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateRequest(MapMarkInfoUpdateRequest other) : this()
		{
			this.markId_ = other.markId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6B1 RID: 54961 RVA: 0x001F92A8 File Offset: 0x001F74A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateRequest Clone()
		{
			return new MapMarkInfoUpdateRequest(this);
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x0600D6B2 RID: 54962 RVA: 0x001F92B0 File Offset: 0x001F74B0
		// (set) Token: 0x0600D6B3 RID: 54963 RVA: 0x001F92B8 File Offset: 0x001F74B8
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

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x0600D6B4 RID: 54964 RVA: 0x001F92C1 File Offset: 0x001F74C1
		// (set) Token: 0x0600D6B5 RID: 54965 RVA: 0x001F92C9 File Offset: 0x001F74C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x0600D6B6 RID: 54966 RVA: 0x001F92D2 File Offset: 0x001F74D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkInfoUpdateRequest);
		}

		// Token: 0x0600D6B7 RID: 54967 RVA: 0x001F92E0 File Offset: 0x001F74E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkInfoUpdateRequest other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6B8 RID: 54968 RVA: 0x001F9330 File Offset: 0x001F7530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D6B9 RID: 54969 RVA: 0x001F9385 File Offset: 0x001F7585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D6BA RID: 54970 RVA: 0x001F9392 File Offset: 0x001F7592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6BB RID: 54971 RVA: 0x001F939C File Offset: 0x001F759C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Pos);
			}
			if (this.MarkId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6BC RID: 54972 RVA: 0x001F93F8 File Offset: 0x001F75F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D6BD RID: 54973 RVA: 0x001F9450 File Offset: 0x001F7650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkInfoUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D6BE RID: 54974 RVA: 0x001F94B8 File Offset: 0x001F76B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6BF RID: 54975 RVA: 0x001F94C4 File Offset: 0x001F76C4
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
				if (num != 34U)
				{
					if (num != 40U)
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
					if (this.pos_ == null)
					{
						this.Pos = new Vector();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x040059B9 RID: 22969
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059BA RID: 22970
		public const int MarkIdFieldNumber = 5;

		// Token: 0x040059BB RID: 22971
		private int markId_;

		// Token: 0x040059BC RID: 22972
		public const int PosFieldNumber = 4;

		// Token: 0x040059BD RID: 22973
		private Vector pos_;
	}
}
