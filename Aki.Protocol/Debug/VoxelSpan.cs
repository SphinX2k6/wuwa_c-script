using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200171D RID: 5917
	public sealed class VoxelSpan : IMessage<VoxelSpan>, IMessage, IEquatable<VoxelSpan>, IDeepCloneable<VoxelSpan>, IBufferMessage
	{
		// Token: 0x0601DB58 RID: 121688 RVA: 0x0045BB47 File Offset: 0x00459D47
		[NullableContext(1)]
		public static VoxelSpan Create()
		{
			return new VoxelSpan();
		}

		// Token: 0x17006528 RID: 25896
		// (get) Token: 0x0601DB59 RID: 121689 RVA: 0x0045BB4E File Offset: 0x00459D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<VoxelSpan> Parser
		{
			get
			{
				return VoxelSpan._parser;
			}
		}

		// Token: 0x17006529 RID: 25897
		// (get) Token: 0x0601DB5A RID: 121690 RVA: 0x0045BB55 File Offset: 0x00459D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700652A RID: 25898
		// (get) Token: 0x0601DB5B RID: 121691 RVA: 0x0045BB58 File Offset: 0x00459D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VoxelSpan.Descriptor;
			}
		}

		// Token: 0x0601DB5C RID: 121692 RVA: 0x0045BB5F File Offset: 0x00459D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VoxelSpan()
		{
		}

		// Token: 0x0601DB5D RID: 121693 RVA: 0x0045BB68 File Offset: 0x00459D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VoxelSpan(VoxelSpan other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.smin_ = other.smin_;
			this.smax_ = other.smax_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DB5E RID: 121694 RVA: 0x0045BBBC File Offset: 0x00459DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VoxelSpan Clone()
		{
			return new VoxelSpan(this);
		}

		// Token: 0x1700652B RID: 25899
		// (get) Token: 0x0601DB5F RID: 121695 RVA: 0x0045BBC4 File Offset: 0x00459DC4
		// (set) Token: 0x0601DB60 RID: 121696 RVA: 0x0045BBCC File Offset: 0x00459DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x1700652C RID: 25900
		// (get) Token: 0x0601DB61 RID: 121697 RVA: 0x0045BBD5 File Offset: 0x00459DD5
		// (set) Token: 0x0601DB62 RID: 121698 RVA: 0x0045BBDD File Offset: 0x00459DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x1700652D RID: 25901
		// (get) Token: 0x0601DB63 RID: 121699 RVA: 0x0045BBE6 File Offset: 0x00459DE6
		// (set) Token: 0x0601DB64 RID: 121700 RVA: 0x0045BBEE File Offset: 0x00459DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Smin
		{
			get
			{
				return this.smin_;
			}
			set
			{
				this.smin_ = value;
			}
		}

		// Token: 0x1700652E RID: 25902
		// (get) Token: 0x0601DB65 RID: 121701 RVA: 0x0045BBF7 File Offset: 0x00459DF7
		// (set) Token: 0x0601DB66 RID: 121702 RVA: 0x0045BBFF File Offset: 0x00459DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Smax
		{
			get
			{
				return this.smax_;
			}
			set
			{
				this.smax_ = value;
			}
		}

		// Token: 0x0601DB67 RID: 121703 RVA: 0x0045BC08 File Offset: 0x00459E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VoxelSpan);
		}

		// Token: 0x0601DB68 RID: 121704 RVA: 0x0045BC18 File Offset: 0x00459E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VoxelSpan other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Smin, other.Smin) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Smax, other.Smax) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DB69 RID: 121705 RVA: 0x0045BCAC File Offset: 0x00459EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.X != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.X);
			}
			if (this.Y != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Y);
			}
			if (this.Smin != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Smin);
			}
			if (this.Smax != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Smax);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DB6A RID: 121706 RVA: 0x0045BD52 File Offset: 0x00459F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DB6B RID: 121707 RVA: 0x0045BD5F File Offset: 0x00459F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DB6C RID: 121708 RVA: 0x0045BD68 File Offset: 0x00459F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.X != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.X);
			}
			if (this.Y != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Y);
			}
			if (this.Smin != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Smin);
			}
			if (this.Smax != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.Smax);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DB6D RID: 121709 RVA: 0x0045BE10 File Offset: 0x0045A010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.X != 0f)
			{
				num += 5;
			}
			if (this.Y != 0f)
			{
				num += 5;
			}
			if (this.Smin != 0f)
			{
				num += 5;
			}
			if (this.Smax != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DB6E RID: 121710 RVA: 0x0045BE7C File Offset: 0x0045A07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VoxelSpan other)
		{
			if (other == null)
			{
				return;
			}
			if (other.X != 0f)
			{
				this.X = other.X;
			}
			if (other.Y != 0f)
			{
				this.Y = other.Y;
			}
			if (other.Smin != 0f)
			{
				this.Smin = other.Smin;
			}
			if (other.Smax != 0f)
			{
				this.Smax = other.Smax;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DB6F RID: 121711 RVA: 0x0045BF08 File Offset: 0x0045A108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DB70 RID: 121712 RVA: 0x0045BF14 File Offset: 0x0045A114
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
				if (num <= 21U)
				{
					if (num == 13U)
					{
						this.X = input.ReadFloat();
						continue;
					}
					if (num == 21U)
					{
						this.Y = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 29U)
					{
						this.Smin = input.ReadFloat();
						continue;
					}
					if (num == 37U)
					{
						this.Smax = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C923 RID: 51491
		private static readonly MessageParser<VoxelSpan> _parser = new MessageParser<VoxelSpan>(() => new VoxelSpan());

		// Token: 0x0400C924 RID: 51492
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C925 RID: 51493
		public const int XFieldNumber = 1;

		// Token: 0x0400C926 RID: 51494
		private float x_;

		// Token: 0x0400C927 RID: 51495
		public const int YFieldNumber = 2;

		// Token: 0x0400C928 RID: 51496
		private float y_;

		// Token: 0x0400C929 RID: 51497
		public const int SminFieldNumber = 3;

		// Token: 0x0400C92A RID: 51498
		private float smin_;

		// Token: 0x0400C92B RID: 51499
		public const int SmaxFieldNumber = 4;

		// Token: 0x0400C92C RID: 51500
		private float smax_;
	}
}
