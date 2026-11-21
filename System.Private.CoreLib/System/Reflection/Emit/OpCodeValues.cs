using System;

namespace System.Reflection.Emit
{
	// Token: 0x020007CA RID: 1994
	internal enum OpCodeValues
	{
		// Token: 0x040018B6 RID: 6326
		Nop,
		// Token: 0x040018B7 RID: 6327
		Break,
		// Token: 0x040018B8 RID: 6328
		Ldarg_0,
		// Token: 0x040018B9 RID: 6329
		Ldarg_1,
		// Token: 0x040018BA RID: 6330
		Ldarg_2,
		// Token: 0x040018BB RID: 6331
		Ldarg_3,
		// Token: 0x040018BC RID: 6332
		Ldloc_0,
		// Token: 0x040018BD RID: 6333
		Ldloc_1,
		// Token: 0x040018BE RID: 6334
		Ldloc_2,
		// Token: 0x040018BF RID: 6335
		Ldloc_3,
		// Token: 0x040018C0 RID: 6336
		Stloc_0,
		// Token: 0x040018C1 RID: 6337
		Stloc_1,
		// Token: 0x040018C2 RID: 6338
		Stloc_2,
		// Token: 0x040018C3 RID: 6339
		Stloc_3,
		// Token: 0x040018C4 RID: 6340
		Ldarg_S,
		// Token: 0x040018C5 RID: 6341
		Ldarga_S,
		// Token: 0x040018C6 RID: 6342
		Starg_S,
		// Token: 0x040018C7 RID: 6343
		Ldloc_S,
		// Token: 0x040018C8 RID: 6344
		Ldloca_S,
		// Token: 0x040018C9 RID: 6345
		Stloc_S,
		// Token: 0x040018CA RID: 6346
		Ldnull,
		// Token: 0x040018CB RID: 6347
		Ldc_I4_M1,
		// Token: 0x040018CC RID: 6348
		Ldc_I4_0,
		// Token: 0x040018CD RID: 6349
		Ldc_I4_1,
		// Token: 0x040018CE RID: 6350
		Ldc_I4_2,
		// Token: 0x040018CF RID: 6351
		Ldc_I4_3,
		// Token: 0x040018D0 RID: 6352
		Ldc_I4_4,
		// Token: 0x040018D1 RID: 6353
		Ldc_I4_5,
		// Token: 0x040018D2 RID: 6354
		Ldc_I4_6,
		// Token: 0x040018D3 RID: 6355
		Ldc_I4_7,
		// Token: 0x040018D4 RID: 6356
		Ldc_I4_8,
		// Token: 0x040018D5 RID: 6357
		Ldc_I4_S,
		// Token: 0x040018D6 RID: 6358
		Ldc_I4,
		// Token: 0x040018D7 RID: 6359
		Ldc_I8,
		// Token: 0x040018D8 RID: 6360
		Ldc_R4,
		// Token: 0x040018D9 RID: 6361
		Ldc_R8,
		// Token: 0x040018DA RID: 6362
		Dup = 37,
		// Token: 0x040018DB RID: 6363
		Pop,
		// Token: 0x040018DC RID: 6364
		Jmp,
		// Token: 0x040018DD RID: 6365
		Call,
		// Token: 0x040018DE RID: 6366
		Calli,
		// Token: 0x040018DF RID: 6367
		Ret,
		// Token: 0x040018E0 RID: 6368
		Br_S,
		// Token: 0x040018E1 RID: 6369
		Brfalse_S,
		// Token: 0x040018E2 RID: 6370
		Brtrue_S,
		// Token: 0x040018E3 RID: 6371
		Beq_S,
		// Token: 0x040018E4 RID: 6372
		Bge_S,
		// Token: 0x040018E5 RID: 6373
		Bgt_S,
		// Token: 0x040018E6 RID: 6374
		Ble_S,
		// Token: 0x040018E7 RID: 6375
		Blt_S,
		// Token: 0x040018E8 RID: 6376
		Bne_Un_S,
		// Token: 0x040018E9 RID: 6377
		Bge_Un_S,
		// Token: 0x040018EA RID: 6378
		Bgt_Un_S,
		// Token: 0x040018EB RID: 6379
		Ble_Un_S,
		// Token: 0x040018EC RID: 6380
		Blt_Un_S,
		// Token: 0x040018ED RID: 6381
		Br,
		// Token: 0x040018EE RID: 6382
		Brfalse,
		// Token: 0x040018EF RID: 6383
		Brtrue,
		// Token: 0x040018F0 RID: 6384
		Beq,
		// Token: 0x040018F1 RID: 6385
		Bge,
		// Token: 0x040018F2 RID: 6386
		Bgt,
		// Token: 0x040018F3 RID: 6387
		Ble,
		// Token: 0x040018F4 RID: 6388
		Blt,
		// Token: 0x040018F5 RID: 6389
		Bne_Un,
		// Token: 0x040018F6 RID: 6390
		Bge_Un,
		// Token: 0x040018F7 RID: 6391
		Bgt_Un,
		// Token: 0x040018F8 RID: 6392
		Ble_Un,
		// Token: 0x040018F9 RID: 6393
		Blt_Un,
		// Token: 0x040018FA RID: 6394
		Switch,
		// Token: 0x040018FB RID: 6395
		Ldind_I1,
		// Token: 0x040018FC RID: 6396
		Ldind_U1,
		// Token: 0x040018FD RID: 6397
		Ldind_I2,
		// Token: 0x040018FE RID: 6398
		Ldind_U2,
		// Token: 0x040018FF RID: 6399
		Ldind_I4,
		// Token: 0x04001900 RID: 6400
		Ldind_U4,
		// Token: 0x04001901 RID: 6401
		Ldind_I8,
		// Token: 0x04001902 RID: 6402
		Ldind_I,
		// Token: 0x04001903 RID: 6403
		Ldind_R4,
		// Token: 0x04001904 RID: 6404
		Ldind_R8,
		// Token: 0x04001905 RID: 6405
		Ldind_Ref,
		// Token: 0x04001906 RID: 6406
		Stind_Ref,
		// Token: 0x04001907 RID: 6407
		Stind_I1,
		// Token: 0x04001908 RID: 6408
		Stind_I2,
		// Token: 0x04001909 RID: 6409
		Stind_I4,
		// Token: 0x0400190A RID: 6410
		Stind_I8,
		// Token: 0x0400190B RID: 6411
		Stind_R4,
		// Token: 0x0400190C RID: 6412
		Stind_R8,
		// Token: 0x0400190D RID: 6413
		Add,
		// Token: 0x0400190E RID: 6414
		Sub,
		// Token: 0x0400190F RID: 6415
		Mul,
		// Token: 0x04001910 RID: 6416
		Div,
		// Token: 0x04001911 RID: 6417
		Div_Un,
		// Token: 0x04001912 RID: 6418
		Rem,
		// Token: 0x04001913 RID: 6419
		Rem_Un,
		// Token: 0x04001914 RID: 6420
		And,
		// Token: 0x04001915 RID: 6421
		Or,
		// Token: 0x04001916 RID: 6422
		Xor,
		// Token: 0x04001917 RID: 6423
		Shl,
		// Token: 0x04001918 RID: 6424
		Shr,
		// Token: 0x04001919 RID: 6425
		Shr_Un,
		// Token: 0x0400191A RID: 6426
		Neg,
		// Token: 0x0400191B RID: 6427
		Not,
		// Token: 0x0400191C RID: 6428
		Conv_I1,
		// Token: 0x0400191D RID: 6429
		Conv_I2,
		// Token: 0x0400191E RID: 6430
		Conv_I4,
		// Token: 0x0400191F RID: 6431
		Conv_I8,
		// Token: 0x04001920 RID: 6432
		Conv_R4,
		// Token: 0x04001921 RID: 6433
		Conv_R8,
		// Token: 0x04001922 RID: 6434
		Conv_U4,
		// Token: 0x04001923 RID: 6435
		Conv_U8,
		// Token: 0x04001924 RID: 6436
		Callvirt,
		// Token: 0x04001925 RID: 6437
		Cpobj,
		// Token: 0x04001926 RID: 6438
		Ldobj,
		// Token: 0x04001927 RID: 6439
		Ldstr,
		// Token: 0x04001928 RID: 6440
		Newobj,
		// Token: 0x04001929 RID: 6441
		Castclass,
		// Token: 0x0400192A RID: 6442
		Isinst,
		// Token: 0x0400192B RID: 6443
		Conv_R_Un,
		// Token: 0x0400192C RID: 6444
		Unbox = 121,
		// Token: 0x0400192D RID: 6445
		Throw,
		// Token: 0x0400192E RID: 6446
		Ldfld,
		// Token: 0x0400192F RID: 6447
		Ldflda,
		// Token: 0x04001930 RID: 6448
		Stfld,
		// Token: 0x04001931 RID: 6449
		Ldsfld,
		// Token: 0x04001932 RID: 6450
		Ldsflda,
		// Token: 0x04001933 RID: 6451
		Stsfld,
		// Token: 0x04001934 RID: 6452
		Stobj,
		// Token: 0x04001935 RID: 6453
		Conv_Ovf_I1_Un,
		// Token: 0x04001936 RID: 6454
		Conv_Ovf_I2_Un,
		// Token: 0x04001937 RID: 6455
		Conv_Ovf_I4_Un,
		// Token: 0x04001938 RID: 6456
		Conv_Ovf_I8_Un,
		// Token: 0x04001939 RID: 6457
		Conv_Ovf_U1_Un,
		// Token: 0x0400193A RID: 6458
		Conv_Ovf_U2_Un,
		// Token: 0x0400193B RID: 6459
		Conv_Ovf_U4_Un,
		// Token: 0x0400193C RID: 6460
		Conv_Ovf_U8_Un,
		// Token: 0x0400193D RID: 6461
		Conv_Ovf_I_Un,
		// Token: 0x0400193E RID: 6462
		Conv_Ovf_U_Un,
		// Token: 0x0400193F RID: 6463
		Box,
		// Token: 0x04001940 RID: 6464
		Newarr,
		// Token: 0x04001941 RID: 6465
		Ldlen,
		// Token: 0x04001942 RID: 6466
		Ldelema,
		// Token: 0x04001943 RID: 6467
		Ldelem_I1,
		// Token: 0x04001944 RID: 6468
		Ldelem_U1,
		// Token: 0x04001945 RID: 6469
		Ldelem_I2,
		// Token: 0x04001946 RID: 6470
		Ldelem_U2,
		// Token: 0x04001947 RID: 6471
		Ldelem_I4,
		// Token: 0x04001948 RID: 6472
		Ldelem_U4,
		// Token: 0x04001949 RID: 6473
		Ldelem_I8,
		// Token: 0x0400194A RID: 6474
		Ldelem_I,
		// Token: 0x0400194B RID: 6475
		Ldelem_R4,
		// Token: 0x0400194C RID: 6476
		Ldelem_R8,
		// Token: 0x0400194D RID: 6477
		Ldelem_Ref,
		// Token: 0x0400194E RID: 6478
		Stelem_I,
		// Token: 0x0400194F RID: 6479
		Stelem_I1,
		// Token: 0x04001950 RID: 6480
		Stelem_I2,
		// Token: 0x04001951 RID: 6481
		Stelem_I4,
		// Token: 0x04001952 RID: 6482
		Stelem_I8,
		// Token: 0x04001953 RID: 6483
		Stelem_R4,
		// Token: 0x04001954 RID: 6484
		Stelem_R8,
		// Token: 0x04001955 RID: 6485
		Stelem_Ref,
		// Token: 0x04001956 RID: 6486
		Ldelem,
		// Token: 0x04001957 RID: 6487
		Stelem,
		// Token: 0x04001958 RID: 6488
		Unbox_Any,
		// Token: 0x04001959 RID: 6489
		Conv_Ovf_I1 = 179,
		// Token: 0x0400195A RID: 6490
		Conv_Ovf_U1,
		// Token: 0x0400195B RID: 6491
		Conv_Ovf_I2,
		// Token: 0x0400195C RID: 6492
		Conv_Ovf_U2,
		// Token: 0x0400195D RID: 6493
		Conv_Ovf_I4,
		// Token: 0x0400195E RID: 6494
		Conv_Ovf_U4,
		// Token: 0x0400195F RID: 6495
		Conv_Ovf_I8,
		// Token: 0x04001960 RID: 6496
		Conv_Ovf_U8,
		// Token: 0x04001961 RID: 6497
		Refanyval = 194,
		// Token: 0x04001962 RID: 6498
		Ckfinite,
		// Token: 0x04001963 RID: 6499
		Mkrefany = 198,
		// Token: 0x04001964 RID: 6500
		Ldtoken = 208,
		// Token: 0x04001965 RID: 6501
		Conv_U2,
		// Token: 0x04001966 RID: 6502
		Conv_U1,
		// Token: 0x04001967 RID: 6503
		Conv_I,
		// Token: 0x04001968 RID: 6504
		Conv_Ovf_I,
		// Token: 0x04001969 RID: 6505
		Conv_Ovf_U,
		// Token: 0x0400196A RID: 6506
		Add_Ovf,
		// Token: 0x0400196B RID: 6507
		Add_Ovf_Un,
		// Token: 0x0400196C RID: 6508
		Mul_Ovf,
		// Token: 0x0400196D RID: 6509
		Mul_Ovf_Un,
		// Token: 0x0400196E RID: 6510
		Sub_Ovf,
		// Token: 0x0400196F RID: 6511
		Sub_Ovf_Un,
		// Token: 0x04001970 RID: 6512
		Endfinally,
		// Token: 0x04001971 RID: 6513
		Leave,
		// Token: 0x04001972 RID: 6514
		Leave_S,
		// Token: 0x04001973 RID: 6515
		Stind_I,
		// Token: 0x04001974 RID: 6516
		Conv_U,
		// Token: 0x04001975 RID: 6517
		Prefix7 = 248,
		// Token: 0x04001976 RID: 6518
		Prefix6,
		// Token: 0x04001977 RID: 6519
		Prefix5,
		// Token: 0x04001978 RID: 6520
		Prefix4,
		// Token: 0x04001979 RID: 6521
		Prefix3,
		// Token: 0x0400197A RID: 6522
		Prefix2,
		// Token: 0x0400197B RID: 6523
		Prefix1,
		// Token: 0x0400197C RID: 6524
		Prefixref,
		// Token: 0x0400197D RID: 6525
		Arglist = 65024,
		// Token: 0x0400197E RID: 6526
		Ceq,
		// Token: 0x0400197F RID: 6527
		Cgt,
		// Token: 0x04001980 RID: 6528
		Cgt_Un,
		// Token: 0x04001981 RID: 6529
		Clt,
		// Token: 0x04001982 RID: 6530
		Clt_Un,
		// Token: 0x04001983 RID: 6531
		Ldftn,
		// Token: 0x04001984 RID: 6532
		Ldvirtftn,
		// Token: 0x04001985 RID: 6533
		Ldarg = 65033,
		// Token: 0x04001986 RID: 6534
		Ldarga,
		// Token: 0x04001987 RID: 6535
		Starg,
		// Token: 0x04001988 RID: 6536
		Ldloc,
		// Token: 0x04001989 RID: 6537
		Ldloca,
		// Token: 0x0400198A RID: 6538
		Stloc,
		// Token: 0x0400198B RID: 6539
		Localloc,
		// Token: 0x0400198C RID: 6540
		Endfilter = 65041,
		// Token: 0x0400198D RID: 6541
		Unaligned_,
		// Token: 0x0400198E RID: 6542
		Volatile_,
		// Token: 0x0400198F RID: 6543
		Tail_,
		// Token: 0x04001990 RID: 6544
		Initobj,
		// Token: 0x04001991 RID: 6545
		Constrained_,
		// Token: 0x04001992 RID: 6546
		Cpblk,
		// Token: 0x04001993 RID: 6547
		Initblk,
		// Token: 0x04001994 RID: 6548
		Rethrow = 65050,
		// Token: 0x04001995 RID: 6549
		Sizeof = 65052,
		// Token: 0x04001996 RID: 6550
		Refanytype,
		// Token: 0x04001997 RID: 6551
		Readonly_
	}
}
