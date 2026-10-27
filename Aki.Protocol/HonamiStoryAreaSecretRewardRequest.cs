using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000764 RID: 1892
	[NetMessage(EMessageId.HonamiStoryAreaSecretRewardRequest)]
	public sealed class HonamiStoryAreaSecretRewardRequest : IMessage<HonamiStoryAreaSecretRewardRequest>, IMessage, IEquatable<HonamiStoryAreaSecretRewardRequest>, IDeepCloneable<HonamiStoryAreaSecretRewardRequest>, IBufferMessage
	{
		// Token: 0x0600AB39 RID: 43833 RVA: 0x0019C17D File Offset: 0x0019A37D
		[NullableContext(1)]
		public static HonamiStoryAreaSecretRewardRequest Create()
		{
			return new HonamiStoryAreaSecretRewardRequest();
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x0600AB3A RID: 43834 RVA: 0x0019C184 File Offset: 0x0019A384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x0600AB3B RID: 43835 RVA: 0x0019C187 File Offset: 0x0019A387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaSecretRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x0019C18E File Offset: 0x0019A38E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardRequest()
		{
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x0019C196 File Offset: 0x0019A396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardRequest(HonamiStoryAreaSecretRewardRequest other) : this()
		{
			this.areaSecretId_ = other.areaSecretId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB3E RID: 43838 RVA: 0x0019C1BB File Offset: 0x0019A3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardRequest Clone()
		{
			return new HonamiStoryAreaSecretRewardRequest(this);
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x0600AB3F RID: 43839 RVA: 0x0019C1C3 File Offset: 0x0019A3C3
		// (set) Token: 0x0600AB40 RID: 43840 RVA: 0x0019C1CB File Offset: 0x0019A3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaSecretId
		{
			get
			{
				return this.areaSecretId_;
			}
			set
			{
				this.areaSecretId_ = value;
			}
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x0019C1D4 File Offset: 0x0019A3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaSecretRewardRequest);
		}

		// Token: 0x0600AB42 RID: 43842 RVA: 0x0019C1E2 File Offset: 0x0019A3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaSecretRewardRequest other)
		{
			return other != null && (other == this || (this.AreaSecretId == other.AreaSecretId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x0019C210 File Offset: 0x0019A410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaSecretId != 0)
			{
				num ^= this.AreaSecretId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB44 RID: 43844 RVA: 0x0019C24F File Offset: 0x0019A44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB45 RID: 43845 RVA: 0x0019C25C File Offset: 0x0019A45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB46 RID: 43846 RVA: 0x0019C265 File Offset: 0x0019A465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaSecretId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.AreaSecretId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB47 RID: 43847 RVA: 0x0019C298 File Offset: 0x0019A498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaSecretId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaSecretId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB48 RID: 43848 RVA: 0x0019C2D6 File Offset: 0x0019A4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAreaSecretRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaSecretId != 0)
			{
				this.AreaSecretId = other.AreaSecretId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB49 RID: 43849 RVA: 0x0019C307 File Offset: 0x0019A507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB4A RID: 43850 RVA: 0x0019C310 File Offset: 0x0019A510
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AreaSecretId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004DC9 RID: 19913
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DCA RID: 19914
		public const int AreaSecretIdFieldNumber = 9;

		// Token: 0x04004DCB RID: 19915
		private int areaSecretId_;
	}
}
