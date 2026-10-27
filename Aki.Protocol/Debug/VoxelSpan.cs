using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x020016A1 RID: 5793
	public sealed class VoxelSpan : IMessage<VoxelSpan>, IMessage, IEquatable<VoxelSpan>, IDeepCloneable<VoxelSpan>, IBufferMessage
	{
		// Token: 0x0601D089 RID: 118921 RVA: 0x0043FE08 File Offset: 0x0043E008
		[NullableContext(1)]
		public static VoxelSpan Create()
		{
			return new VoxelSpan();
		}

		// Token: 0x17006283 RID: 25219
		// (get) Token: 0x0601D08A RID: 118922 RVA: 0x0043FE0F File Offset: 0x0043E00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<VoxelSpan> Parser
		{
			get
			{
				return VoxelSpan._parser;
			}
		}

		// Token: 0x17006284 RID: 25220
		// (get) Token: 0x0601D08B RID: 118923 RVA: 0x0043FE16 File Offset: 0x0043E016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006285 RID: 25221
		// (get) Token: 0x0601D08C RID: 118924 RVA: 0x0043FE19 File Offset: 0x0043E019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VoxelSpan.Descriptor;
			}
		}

		// Token: 0x0601D08D RID: 118925 RVA: 0x0043FE20 File Offset: 0x0043E020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VoxelSpan()
		{
		}

		// Token: 0x0601D08E RID: 118926 RVA: 0x0043FE28 File Offset: 0x0043E028
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

		// Token: 0x0601D08F RID: 118927 RVA: 0x0043FE7C File Offset: 0x0043E07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VoxelSpan Clone()
		{
			return new VoxelSpan(this);
		}

		// Token: 0x17006286 RID: 25222
		// (get) Token: 0x0601D090 RID: 118928 RVA: 0x0043FE84 File Offset: 0x0043E084
		// (set) Token: 0x0601D091 RID: 118929 RVA: 0x0043FE8C File Offset: 0x0043E08C
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

		// Token: 0x17006287 RID: 25223
		// (get) Token: 0x0601D092 RID: 118930 RVA: 0x0043FE95 File Offset: 0x0043E095
		// (set) Token: 0x0601D093 RID: 118931 RVA: 0x0043FE9D File Offset: 0x0043E09D
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

		// Token: 0x17006288 RID: 25224
		// (get) Token: 0x0601D094 RID: 118932 RVA: 0x0043FEA6 File Offset: 0x0043E0A6
		// (set) Token: 0x0601D095 RID: 118933 RVA: 0x0043FEAE File Offset: 0x0043E0AE
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

		// Token: 0x17006289 RID: 25225
		// (get) Token: 0x0601D096 RID: 118934 RVA: 0x0043FEB7 File Offset: 0x0043E0B7
		// (set) Token: 0x0601D097 RID: 118935 RVA: 0x0043FEBF File Offset: 0x0043E0BF
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

		// Token: 0x0601D098 RID: 118936 RVA: 0x0043FEC8 File Offset: 0x0043E0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VoxelSpan);
		}

		// Token: 0x0601D099 RID: 118937 RVA: 0x0043FED8 File Offset: 0x0043E0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VoxelSpan other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Smin, other.Smin) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Smax, other.Smax) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D09A RID: 118938 RVA: 0x0043FF6C File Offset: 0x0043E16C
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

		// Token: 0x0601D09B RID: 118939 RVA: 0x00440012 File Offset: 0x0043E212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D09C RID: 118940 RVA: 0x0044001F File Offset: 0x0043E21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D09D RID: 118941 RVA: 0x00440028 File Offset: 0x0043E228
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

		// Token: 0x0601D09E RID: 118942 RVA: 0x004400D0 File Offset: 0x0043E2D0
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

		// Token: 0x0601D09F RID: 118943 RVA: 0x0044013C File Offset: 0x0043E33C
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

		// Token: 0x0601D0A0 RID: 118944 RVA: 0x004401C8 File Offset: 0x0043E3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D0A1 RID: 118945 RVA: 0x004401D4 File Offset: 0x0043E3D4
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

		// Token: 0x0400C3F4 RID: 50164
		private static readonly MessageParser<VoxelSpan> _parser = new MessageParser<VoxelSpan>(() => new VoxelSpan());

		// Token: 0x0400C3F5 RID: 50165
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C3F6 RID: 50166
		public const int XFieldNumber = 1;

		// Token: 0x0400C3F7 RID: 50167
		private float x_;

		// Token: 0x0400C3F8 RID: 50168
		public const int YFieldNumber = 2;

		// Token: 0x0400C3F9 RID: 50169
		private float y_;

		// Token: 0x0400C3FA RID: 50170
		public const int SminFieldNumber = 3;

		// Token: 0x0400C3FB RID: 50171
		private float smin_;

		// Token: 0x0400C3FC RID: 50172
		public const int SmaxFieldNumber = 4;

		// Token: 0x0400C3FD RID: 50173
		private float smax_;
	}
}
