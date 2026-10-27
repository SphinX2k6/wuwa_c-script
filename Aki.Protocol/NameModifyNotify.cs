using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AEE RID: 2798
	[NetMessage(EMessageId.NameModifyNotify)]
	public sealed class NameModifyNotify : IMessage<NameModifyNotify>, IMessage, IEquatable<NameModifyNotify>, IDeepCloneable<NameModifyNotify>, IBufferMessage
	{
		// Token: 0x0600F34D RID: 62285 RVA: 0x00238416 File Offset: 0x00236616
		[NullableContext(1)]
		public static NameModifyNotify Create()
		{
			return new NameModifyNotify();
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x0600F34E RID: 62286 RVA: 0x0023841D File Offset: 0x0023661D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x0600F34F RID: 62287 RVA: 0x00238420 File Offset: 0x00236620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NameModifyNotify.Descriptor;
			}
		}

		// Token: 0x0600F350 RID: 62288 RVA: 0x00238427 File Offset: 0x00236627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NameModifyNotify()
		{
		}

		// Token: 0x0600F351 RID: 62289 RVA: 0x0023843A File Offset: 0x0023663A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NameModifyNotify(NameModifyNotify other) : this()
		{
			this.name_ = other.name_;
			this.lastModifyNameTime_ = other.lastModifyNameTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F352 RID: 62290 RVA: 0x0023846B File Offset: 0x0023666B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NameModifyNotify Clone()
		{
			return new NameModifyNotify(this);
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x0600F353 RID: 62291 RVA: 0x00238473 File Offset: 0x00236673
		// (set) Token: 0x0600F354 RID: 62292 RVA: 0x0023847B File Offset: 0x0023667B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x0600F355 RID: 62293 RVA: 0x0023848E File Offset: 0x0023668E
		// (set) Token: 0x0600F356 RID: 62294 RVA: 0x00238496 File Offset: 0x00236696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastModifyNameTime
		{
			get
			{
				return this.lastModifyNameTime_;
			}
			set
			{
				this.lastModifyNameTime_ = value;
			}
		}

		// Token: 0x0600F357 RID: 62295 RVA: 0x0023849F File Offset: 0x0023669F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NameModifyNotify);
		}

		// Token: 0x0600F358 RID: 62296 RVA: 0x002384B0 File Offset: 0x002366B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NameModifyNotify other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.LastModifyNameTime == other.LastModifyNameTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F359 RID: 62297 RVA: 0x00238500 File Offset: 0x00236700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.LastModifyNameTime != 0L)
			{
				num ^= this.LastModifyNameTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F35A RID: 62298 RVA: 0x0023855A File Offset: 0x0023675A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F35B RID: 62299 RVA: 0x00238567 File Offset: 0x00236767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F35C RID: 62300 RVA: 0x00238570 File Offset: 0x00236770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Name);
			}
			if (this.LastModifyNameTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.LastModifyNameTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F35D RID: 62301 RVA: 0x002385D0 File Offset: 0x002367D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.LastModifyNameTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastModifyNameTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F35E RID: 62302 RVA: 0x0023862C File Offset: 0x0023682C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NameModifyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.LastModifyNameTime != 0L)
			{
				this.LastModifyNameTime = other.LastModifyNameTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F35F RID: 62303 RVA: 0x00238681 File Offset: 0x00236881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F360 RID: 62304 RVA: 0x0023868C File Offset: 0x0023688C
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
				if (num != 82U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LastModifyNameTime = input.ReadInt64();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04006215 RID: 25109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006216 RID: 25110
		public const int NameFieldNumber = 10;

		// Token: 0x04006217 RID: 25111
		private string name_ = "";

		// Token: 0x04006218 RID: 25112
		public const int LastModifyNameTimeFieldNumber = 11;

		// Token: 0x04006219 RID: 25113
		private long lastModifyNameTime_;
	}
}
