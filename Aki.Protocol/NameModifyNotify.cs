using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADD RID: 2781
	[NetMessage(EMessageId.NameModifyNotify)]
	public sealed class NameModifyNotify : IMessage<NameModifyNotify>, IMessage, IEquatable<NameModifyNotify>, IDeepCloneable<NameModifyNotify>, IBufferMessage
	{
		// Token: 0x0600F233 RID: 62003 RVA: 0x0023620E File Offset: 0x0023440E
		[NullableContext(1)]
		public static NameModifyNotify Create()
		{
			return new NameModifyNotify();
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x0600F234 RID: 62004 RVA: 0x00236215 File Offset: 0x00234415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x0600F235 RID: 62005 RVA: 0x00236218 File Offset: 0x00234418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NameModifyNotify.Descriptor;
			}
		}

		// Token: 0x0600F236 RID: 62006 RVA: 0x0023621F File Offset: 0x0023441F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NameModifyNotify()
		{
		}

		// Token: 0x0600F237 RID: 62007 RVA: 0x00236232 File Offset: 0x00234432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NameModifyNotify(NameModifyNotify other) : this()
		{
			this.name_ = other.name_;
			this.lastModifyNameTime_ = other.lastModifyNameTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F238 RID: 62008 RVA: 0x00236263 File Offset: 0x00234463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NameModifyNotify Clone()
		{
			return new NameModifyNotify(this);
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x0600F239 RID: 62009 RVA: 0x0023626B File Offset: 0x0023446B
		// (set) Token: 0x0600F23A RID: 62010 RVA: 0x00236273 File Offset: 0x00234473
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

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x0600F23B RID: 62011 RVA: 0x00236286 File Offset: 0x00234486
		// (set) Token: 0x0600F23C RID: 62012 RVA: 0x0023628E File Offset: 0x0023448E
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

		// Token: 0x0600F23D RID: 62013 RVA: 0x00236297 File Offset: 0x00234497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NameModifyNotify);
		}

		// Token: 0x0600F23E RID: 62014 RVA: 0x002362A8 File Offset: 0x002344A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NameModifyNotify other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.LastModifyNameTime == other.LastModifyNameTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F23F RID: 62015 RVA: 0x002362F8 File Offset: 0x002344F8
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

		// Token: 0x0600F240 RID: 62016 RVA: 0x00236352 File Offset: 0x00234552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F241 RID: 62017 RVA: 0x0023635F File Offset: 0x0023455F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F242 RID: 62018 RVA: 0x00236368 File Offset: 0x00234568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LastModifyNameTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.LastModifyNameTime);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F243 RID: 62019 RVA: 0x002363C8 File Offset: 0x002345C8
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

		// Token: 0x0600F244 RID: 62020 RVA: 0x00236424 File Offset: 0x00234624
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

		// Token: 0x0600F245 RID: 62021 RVA: 0x00236479 File Offset: 0x00234679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F246 RID: 62022 RVA: 0x00236484 File Offset: 0x00234684
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
				if (num != 32U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.LastModifyNameTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400621E RID: 25118
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400621F RID: 25119
		public const int NameFieldNumber = 11;

		// Token: 0x04006220 RID: 25120
		private string name_ = "";

		// Token: 0x04006221 RID: 25121
		public const int LastModifyNameTimeFieldNumber = 4;

		// Token: 0x04006222 RID: 25122
		private long lastModifyNameTime_;
	}
}
