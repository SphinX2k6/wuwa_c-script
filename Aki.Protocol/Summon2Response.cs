using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AB RID: 4779
	[NetMessage(EMessageId.Summon2Response)]
	public sealed class Summon2Response : IMessage<Summon2Response>, IMessage, IEquatable<Summon2Response>, IDeepCloneable<Summon2Response>, IBufferMessage
	{
		// Token: 0x060196F0 RID: 104176 RVA: 0x003B2566 File Offset: 0x003B0766
		[NullableContext(1)]
		public static Summon2Response Create()
		{
			return new Summon2Response();
		}

		// Token: 0x170055C5 RID: 21957
		// (get) Token: 0x060196F1 RID: 104177 RVA: 0x003B256D File Offset: 0x003B076D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055C6 RID: 21958
		// (get) Token: 0x060196F2 RID: 104178 RVA: 0x003B2570 File Offset: 0x003B0770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Summon2Response.Descriptor;
			}
		}

		// Token: 0x060196F3 RID: 104179 RVA: 0x003B2577 File Offset: 0x003B0777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Response()
		{
		}

		// Token: 0x060196F4 RID: 104180 RVA: 0x003B257F File Offset: 0x003B077F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Response(Summon2Response other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060196F5 RID: 104181 RVA: 0x003B25B0 File Offset: 0x003B07B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Response Clone()
		{
			return new Summon2Response(this);
		}

		// Token: 0x170055C7 RID: 21959
		// (get) Token: 0x060196F6 RID: 104182 RVA: 0x003B25B8 File Offset: 0x003B07B8
		// (set) Token: 0x060196F7 RID: 104183 RVA: 0x003B25C0 File Offset: 0x003B07C0
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

		// Token: 0x170055C8 RID: 21960
		// (get) Token: 0x060196F8 RID: 104184 RVA: 0x003B25C9 File Offset: 0x003B07C9
		// (set) Token: 0x060196F9 RID: 104185 RVA: 0x003B25D1 File Offset: 0x003B07D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = value;
			}
		}

		// Token: 0x060196FA RID: 104186 RVA: 0x003B25DA File Offset: 0x003B07DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Summon2Response);
		}

		// Token: 0x060196FB RID: 104187 RVA: 0x003B25E8 File Offset: 0x003B07E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Summon2Response other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Version == other.Version && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060196FC RID: 104188 RVA: 0x003B2628 File Offset: 0x003B0828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Version != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060196FD RID: 104189 RVA: 0x003B2686 File Offset: 0x003B0886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060196FE RID: 104190 RVA: 0x003B2693 File Offset: 0x003B0893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060196FF RID: 104191 RVA: 0x003B269C File Offset: 0x003B089C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Version);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019700 RID: 104192 RVA: 0x003B26F4 File Offset: 0x003B08F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Version != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019701 RID: 104193 RVA: 0x003B274C File Offset: 0x003B094C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Summon2Response other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Version != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019702 RID: 104194 RVA: 0x003B279C File Offset: 0x003B099C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019703 RID: 104195 RVA: 0x003B27A8 File Offset: 0x003B09A8
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
					if (num != 96U)
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
					this.Version = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400954E RID: 38222
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400954F RID: 38223
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04009550 RID: 38224
		private ErrorCode errorCode_;

		// Token: 0x04009551 RID: 38225
		public const int VersionFieldNumber = 1;

		// Token: 0x04009552 RID: 38226
		private int version_;
	}
}
