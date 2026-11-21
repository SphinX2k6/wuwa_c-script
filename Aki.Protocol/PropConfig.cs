using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDA RID: 3546
	public sealed class PropConfig : IMessage<PropConfig>, IMessage, IEquatable<PropConfig>, IDeepCloneable<PropConfig>, IBufferMessage
	{
		// Token: 0x060131B0 RID: 78256 RVA: 0x002C9089 File Offset: 0x002C7289
		[NullableContext(1)]
		public static PropConfig Create()
		{
			return new PropConfig();
		}

		// Token: 0x17003F67 RID: 16231
		// (get) Token: 0x060131B1 RID: 78257 RVA: 0x002C9090 File Offset: 0x002C7290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PropConfig> Parser
		{
			get
			{
				return PropConfig._parser;
			}
		}

		// Token: 0x17003F68 RID: 16232
		// (get) Token: 0x060131B2 RID: 78258 RVA: 0x002C9097 File Offset: 0x002C7297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F69 RID: 16233
		// (get) Token: 0x060131B3 RID: 78259 RVA: 0x002C909A File Offset: 0x002C729A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PropConfig.Descriptor;
			}
		}

		// Token: 0x060131B4 RID: 78260 RVA: 0x002C90A1 File Offset: 0x002C72A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropConfig()
		{
		}

		// Token: 0x060131B5 RID: 78261 RVA: 0x002C90A9 File Offset: 0x002C72A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropConfig(PropConfig other) : this()
		{
			this.id_ = other.id_;
			this.value_ = other.value_;
			this.isRatio_ = other.isRatio_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060131B6 RID: 78262 RVA: 0x002C90E6 File Offset: 0x002C72E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropConfig Clone()
		{
			return new PropConfig(this);
		}

		// Token: 0x17003F6A RID: 16234
		// (get) Token: 0x060131B7 RID: 78263 RVA: 0x002C90EE File Offset: 0x002C72EE
		// (set) Token: 0x060131B8 RID: 78264 RVA: 0x002C90F6 File Offset: 0x002C72F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003F6B RID: 16235
		// (get) Token: 0x060131B9 RID: 78265 RVA: 0x002C90FF File Offset: 0x002C72FF
		// (set) Token: 0x060131BA RID: 78266 RVA: 0x002C9107 File Offset: 0x002C7307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x17003F6C RID: 16236
		// (get) Token: 0x060131BB RID: 78267 RVA: 0x002C9110 File Offset: 0x002C7310
		// (set) Token: 0x060131BC RID: 78268 RVA: 0x002C9118 File Offset: 0x002C7318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRatio
		{
			get
			{
				return this.isRatio_;
			}
			set
			{
				this.isRatio_ = value;
			}
		}

		// Token: 0x060131BD RID: 78269 RVA: 0x002C9121 File Offset: 0x002C7321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PropConfig);
		}

		// Token: 0x060131BE RID: 78270 RVA: 0x002C9130 File Offset: 0x002C7330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PropConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Value, other.Value) && this.IsRatio == other.IsRatio && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060131BF RID: 78271 RVA: 0x002C9194 File Offset: 0x002C7394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Value != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Value);
			}
			if (this.IsRatio)
			{
				num ^= this.IsRatio.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060131C0 RID: 78272 RVA: 0x002C920C File Offset: 0x002C740C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060131C1 RID: 78273 RVA: 0x002C9219 File Offset: 0x002C7419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060131C2 RID: 78274 RVA: 0x002C9224 File Offset: 0x002C7424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Value != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Value);
			}
			if (this.IsRatio)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsRatio);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060131C3 RID: 78275 RVA: 0x002C92A0 File Offset: 0x002C74A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Value != 0f)
			{
				num += 5;
			}
			if (this.IsRatio)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060131C4 RID: 78276 RVA: 0x002C92FC File Offset: 0x002C74FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PropConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Value != 0f)
			{
				this.Value = other.Value;
			}
			if (other.IsRatio)
			{
				this.IsRatio = other.IsRatio;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060131C5 RID: 78277 RVA: 0x002C9365 File Offset: 0x002C7565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060131C6 RID: 78278 RVA: 0x002C9370 File Offset: 0x002C7570
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
					if (num != 21U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsRatio = input.ReadBool();
						}
					}
					else
					{
						this.Value = input.ReadFloat();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007630 RID: 30256
		private static readonly MessageParser<PropConfig> _parser = new MessageParser<PropConfig>(() => new PropConfig());

		// Token: 0x04007631 RID: 30257
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007632 RID: 30258
		public const int IdFieldNumber = 1;

		// Token: 0x04007633 RID: 30259
		private int id_;

		// Token: 0x04007634 RID: 30260
		public const int ValueFieldNumber = 2;

		// Token: 0x04007635 RID: 30261
		private float value_;

		// Token: 0x04007636 RID: 30262
		public const int IsRatioFieldNumber = 3;

		// Token: 0x04007637 RID: 30263
		private bool isRatio_;
	}
}
